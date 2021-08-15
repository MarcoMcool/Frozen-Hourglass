using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderPhysics : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject topExplosivePosition;

    public PhysicMaterial pm;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            rb.AddExplosionForce(500f, topExplosivePosition.transform.position, 10f);

            StartCoroutine(Slide());

            StartCoroutine(ResetSlide());
        }

        
    }

    IEnumerator Slide()
    {
        yield return new WaitForSeconds(0.03f);
        pm.dynamicFriction = 0;
        pm.staticFriction = 0;
    }

    IEnumerator ResetSlide()
    {
        yield return new WaitForSeconds(2f);
        pm.dynamicFriction = 0.3f;
        pm.staticFriction = 0.3f;
    }
}
