using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workers : MonoBehaviour
{
    public GameController gameController;

    public Vector3 endPos;
    public Vector3 lookPos;
    bool workerMove;
    float speed = 4f;
    public bool rotationFinish = false;
    public Animator animator;

    public GameObject teleportRing;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        teleportRing.SetActive(false);
        Collider[] collidersOnObject = GetComponentsInChildren<Collider>();
    }

    void Update()
    {
        if (gameController.stepsCount == 3)
        {
            teleportRing.SetActive(true);
            if (workerMove)
            {
                teleportRing.SetActive(false);
                animator.SetBool("Walk", true);
                WorkerMovement();
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PlayerHands")
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) || OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
            {
                if (gameController.stepsCount == 3)
                {
                    teleportRing.SetActive(true);
                    workerMove = true;
                    gameObject.GetComponent<OVRGrabbable>().enabled = false;
                }
            }
        }
    }

    public void WorkerMovement()
    {
        Vector3 targetDirection = endPos - transform.position;
        if (!rotationFinish)
        {
            if (Vector3.Angle(transform.forward, targetDirection) > 1f)
            {

                float singleStep = 2f * Time.deltaTime;
                Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
                Debug.DrawLine(transform.position, newDirection, Color.yellow);
                transform.rotation = Quaternion.LookRotation(newDirection);
            }
            else
            {
                rotationFinish = true;
            }
        }
        else
        {
            float step = speed * Time.deltaTime;

            if (Vector3.Distance(transform.position, endPos) > 1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, endPos, step);
            }
            else
            {
                Vector3 lookDirection1 = lookPos - transform.position;
                Vector3 lookDirection = new Vector3(lookDirection1.x, 0, lookDirection1.z);
                if (Vector3.Angle(transform.forward, lookDirection) > 5f)
                {
                    float singleStep = 2f * Time.deltaTime;
                    Vector3 newDirection = Vector3.RotateTowards(transform.forward, lookDirection, singleStep, 0.0f);
                    Debug.DrawLine(transform.position, newDirection, Color.red);
                    transform.rotation = Quaternion.LookRotation(newDirection);
                }
                else
                {
                    animator.SetBool("Spotting", false);
                    animator.SetBool("Working", false);
                    animator.SetBool("Walk", false);
                    animator.Play("Base Layer.Idle");

                    workerMove = false;
                    gameController.stepsCount++;
                }
            }
        }
    }
    public void Reset_Worker(int step)
    {
        if (step < 3)
        {
            teleportRing.SetActive(true);
            transform.position = startPos;
            transform.rotation = Quaternion.identity;
        }
        else
        {
            StartCoroutine(RotateWorker());
        }
    }

    IEnumerator RotateWorker()
    {
        teleportRing.SetActive(false);
        transform.position = endPos;
        Vector3 lookDirection1 = lookPos - transform.position;
        Vector3 lookDirection = new Vector3(lookDirection1.x, 0, lookDirection1.z);
        while (Vector3.Angle(transform.forward, lookDirection) > 5f)
        {
            float singleStep = 2f * Time.deltaTime;
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, lookDirection, singleStep, 0.0f);
            Debug.DrawLine(transform.position, newDirection, Color.red);
            transform.rotation = Quaternion.LookRotation(newDirection);
        }
        yield return null;
    }
}
