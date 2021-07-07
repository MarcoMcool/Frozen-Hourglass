using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workers : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<OVRGrabbable>().isGrabbed)
        {
            gameObject.SetActive(false);
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
