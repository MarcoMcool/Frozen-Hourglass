using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public GameObject safe_zone_line;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        safe_zone_line.SetActive(gameObject.GetComponent<OVRGrabbable>().isGrabbed);
    }
}
