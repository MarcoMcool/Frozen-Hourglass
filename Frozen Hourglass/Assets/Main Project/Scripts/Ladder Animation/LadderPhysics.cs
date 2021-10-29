using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LadderPhysics : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject topExplosivePosition;

    public GameObject floor;
    public PhysicMaterial pmSlide;
    public PhysicMaterial pmNoSlide;
    public MeshCollider meshCollider;
    public bool done;
    bool ladderfall = false;
    public Vector3 start_Pos;
    public Quaternion start_Rot;
    public AudioSource ladderSound;

    void Start()
    {
        meshCollider = GetComponent<MeshCollider>();
        meshCollider.isTrigger = false;
        start_Pos = transform.position;
        start_Rot = transform.rotation;
    }

    void Update()
    {
    }
    public void Reset_Ani()
    {
        print("RESET");
        if (ladderSound.isPlaying)
        {
            ladderSound.Stop();
        }
        done = false;
        floor.SetActive(true);
        transform.position = start_Pos;
        transform.rotation = start_Rot;
    }
    public void StartFall()
    {
        Reset_Ani();
        StartCoroutine(WaitTime());
    }

    private void FixedUpdate()
    {
        if (ladderfall)
        {
            Ladder();
            StartCoroutine(Slide());

            StartCoroutine(ResetSlide());
            
        }
    }

    void Ladder()
    {
        done = false;
        rb.AddExplosionForce(500f, topExplosivePosition.transform.position, 10f);
        ladderfall = false;
    }

    IEnumerator Slide()
    {
        yield return new WaitForSeconds(0.03f);
        meshCollider.material = pmSlide;
    }

    IEnumerator ResetSlide()
    {
        yield return new WaitForSeconds(1.7f);
        floor.SetActive(false);
        meshCollider.material = pmNoSlide;
        done = true;
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1.5f);
        ladderfall = true;
    }
}
