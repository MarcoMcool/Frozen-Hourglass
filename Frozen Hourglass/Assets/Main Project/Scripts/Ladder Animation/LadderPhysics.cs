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

    void Start()
    {
        meshCollider = GetComponent<MeshCollider>();
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.P))
        //{
        //    StartFall();
        //}

        //if (OVRInput.GetDown(OVRInput.RawButton.B))
        //{
        //    StartFall();
        //}
    }
    public void StartFall()
    {
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
        print("DONE");
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1.5f);
        ladderfall = true;
    }
}
