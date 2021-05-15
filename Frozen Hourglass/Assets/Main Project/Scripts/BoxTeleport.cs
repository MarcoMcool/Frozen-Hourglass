using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTeleport : MonoBehaviour
    
{
    public GameObject Box;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Oculus_CrossPlatform_Button2"))
        {
            Box.transform.rotation = transform.rotation;
            Vector3 spot = new Vector3(transform.position.x, Box.transform.position.y, transform.position.z);
            Box.transform.position = spot+Box.transform.forward;
            
        } 
    }
}
