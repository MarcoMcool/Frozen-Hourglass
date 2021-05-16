using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;

public class PlayerCollection: MonoBehaviour
{
    TouchController controller;
    public GameObject handPopup; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            if (handPopup.activeSelf)
            {
                handPopup.SetActive(false);
            }
            else
            {
                handPopup.SetActive(true);
            }
            
        }
    }
}