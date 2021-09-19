using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testing : MonoBehaviour
{
    public GameObject leftHand;
    public bool SPIN = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            SPIN = !SPIN;
        }
        if (SPIN)
        {
            leftHand.transform.rotation = Random.rotation;
        }
    }
}
