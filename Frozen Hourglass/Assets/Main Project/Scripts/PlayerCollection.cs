using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;

public class PlayerCollection: MonoBehaviour
{
    TouchController controller;
    public GameObject handPopup;
    float timer = 0f;
    public GameController gc;
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
        if (Input.GetButtonDown("Oculus_CrossPlatform_SecondaryIndexTrigger"))
        {
            //Make Popup hide when doing teleport
        }
        
    }
}
