using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabCubes: MonoBehaviour
{
    Vector3 startPos;
    OVRGrabbable grabber;
    void Start()
    {
        startPos = transform.position;
        grabber = GetComponent<OVRGrabbable>();
    }

    void Update()
    {
        bool temp = grabber.isGrabbed;
        if (!temp && Vector3.Distance(startPos, transform.position) > 1f)
        {
            transform.position = startPos;
        }
       
        //if (Vector3.Distance(startPos, transform.position) > 2f)
        //{
        //    transform.position = startPos;
        //}
    }
}
