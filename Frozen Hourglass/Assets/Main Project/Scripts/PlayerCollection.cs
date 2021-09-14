using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;

public class PlayerCollection: MonoBehaviour
{
    TouchController controller;
    public GameObject RightPopup;
    public GameObject handPopup;
    float timer = 0f;
    public GameController gc;
    bool on;
    public GameObject laserPointer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //if (OVRInput.GetDown(OVRInput.Button.Four))
        if (Input.GetButtonDown("Oculus_CrossPlatform_Button4") && gc.popupAllowed)
        {
            if (timer >= 0.2f)
            {
                if (handPopup.activeSelf)
                {
                    handPopup.SetActive(false);
                    timer = 0f;
                }
                else
                {
                    handPopup.SetActive(true);
                    timer = 0f;
                }
            }
        }
       

        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            print("test here pointer");
            on = true;
            laserPointer.SetActive(true);
        }
        if (OVRInput.GetDown(OVRInput.RawButton.B) && on)
        {
            on = false;
            laserPointer.SetActive(false);
            print("line rendere disabled");
        }
        //if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryIndexTrigger"))
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            print("HERE");
            
            RightPopup.SetActive(false);
        }

    }

    void TestControllerPresses()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            print("right hand trigger");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            print("left hand trigger");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            print("left hand grip");
        }
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            print("right hand grip");
        }
    }
}
