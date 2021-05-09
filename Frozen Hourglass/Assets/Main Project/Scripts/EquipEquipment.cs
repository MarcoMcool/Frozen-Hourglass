using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipEquipment : MonoBehaviour
{
    public OVRGrabbable grabbable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (grabbable.isGrabbed)
        {
            print(this.name + " Item was grabbed");
        }
    }
}
