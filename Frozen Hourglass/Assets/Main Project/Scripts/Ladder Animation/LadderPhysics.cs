using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class LadderPhysics : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject topExplosivePosition;

    public PhysicMaterial pmSlide;
    public PhysicMaterial pmNoSlide;
    public MeshCollider meshCollider;
    // Start is called before the first frame update
    void Start()
    {
        meshCollider = GetComponent<MeshCollider>();
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
        meshCollider.material = pmSlide;
        //pmNoSlide.dynamicFriction = 0;
        //pmNoSlide.staticFriction = 0;
    }

    IEnumerator ResetSlide()
    {
        yield return new WaitForSeconds(1.7f);
        meshCollider.material = pmNoSlide;
        //pmSlide.dynamicFriction = 0.3f;
        //pmSlide.staticFriction = 0.3f;
    }
}
