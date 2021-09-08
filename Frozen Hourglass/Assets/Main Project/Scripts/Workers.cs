using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workers: MonoBehaviour
{
    public GameController gameController;

    Vector3 startPos;
    public Vector3 endPos;
    public Vector3 lookPos;
    bool workerMove;
    float speed = 4f;

    public bool rotationFinish = false;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(5, 1.006f, -2.415f);
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {



        if (gameObject.GetComponent<OVRGrabbable>().isGrabbed || Input.GetKeyDown(KeyCode.M))
        {
            workerMove = true;
            //gameController.stepsCount++;
           
            // Move worker to a distance away from house
            //if (Vector3.Distance(startPos, endPos) <= 2f)
            //{
            //    workerMove = false;
            //    transform.position += new Vector3(3, 0, 0) * Time.deltaTime;

            //}
        }
        if (workerMove)
        {
            WorkerMovement();
        }
        if (gameController.stepsCount == 3)
        {
            //gameObject.SetActive(false);
        }
    }

    public void WorkerMovement()
    {
        Vector3 targetDirection = endPos - transform.position;
        if (!rotationFinish)
        {
            if (Vector3.Angle(transform.forward, targetDirection) > 1f)
            {

                print("here first");
                float singleStep = 1f * Time.deltaTime;

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
            print("moving here");
            float step = speed * Time.deltaTime;
            
            if (Vector3.Distance(transform.position, endPos) > 1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, endPos, step);
                
            }
            else
            {
                Vector3 lookDirection = lookPos - transform.position;
                if (Vector3.Angle(transform.forward, lookDirection) > 5f)
                {
                    print("here");
                    float singleStep = 1f * Time.deltaTime;

                    Vector3 newDirection = Vector3.RotateTowards(transform.forward, lookDirection, singleStep, 0.0f);

                    Debug.DrawLine(transform.position, newDirection, Color.red);

                    transform.rotation = Quaternion.LookRotation(newDirection);
                }
                else
                {
                    workerMove = false;
                }
            }
        }
    }



    //void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "PlayerHands")
    //    {
    //        if (worker1.GetComponent<OVRGrabbable>().isGrabbed)
    //        {
    //            worker1.SetActive(false);
    //        }
    //    }
    //}
}
