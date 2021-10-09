using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;

public class PlayerCollection: MonoBehaviour
{
    TouchController controller;
    public GameObject RightPopup;
    public GameObject handPopup;
    //public GameObject LCanvas;
    float timer = 0f;
    public GameController gc;
    public GameObject laserPointer;

    public GameObject playerPosition;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    // Start is called before the first frame update
    void Start()
    {
        wall1.SetActive(false);
        wall2.SetActive(false);
        wall3.SetActive(false);
        wall4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //TestControllerPresses();
        timer += Time.deltaTime;
        //if (OVRInput.GetDown(OVRInput.Button.Four))
        if (OVRInput.Get(OVRInput.RawButton.Y) && gc.popupAllowed)
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


        if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            //print("test here pointer");
            laserPointer.SetActive(true);
        }
        else
        {
            laserPointer.SetActive(false);
            //print("line rendere disabled");
        }
        //if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryIndexTrigger"))

        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp))
        {
            //print("HERE");

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
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            print("b button clicked");
        }
    }

    //public void closePrompt()
    //{
    //    if (OVRInput.GetDown(OVRInput.RawButton.X))
    //    {
    //        LCanvas.SetActive(false);
    //    }
    //}


    void WallLimit()
    {
        if (Vector3.Distance(playerPosition.transform.position, wall1.transform.position) < 3f)
        {
            wall1.SetActive(true);
        }
        else
        {
            wall1.SetActive(false);
        }
        if (Vector3.Distance(playerPosition.transform.position, wall2.transform.position) < 3f)
        {
            wall2.SetActive(true);
        }
        else
        {
            wall2.SetActive(false);
        }
        if (Vector3.Distance(playerPosition.transform.position, wall3.transform.position) < 3f)
        {
            wall3.SetActive(true);
        }
        else
        {
            wall3.SetActive(false);
        }
        if (Vector3.Distance(playerPosition.transform.position, wall4.transform.position) < 3f)
        {
            wall4.SetActive(true);
        }
        else
        {
            wall4.SetActive(false);
        }
    }
}
