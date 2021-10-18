using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVRTouchSample;

public class PlayerCollection: MonoBehaviour
{
    public GameObject RightPopup;
    public GameObject handPopup;
    float timer = 0f;
    public GameController gc;
    public GameObject laserPointer;
    public GameObject Sphere;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (OVRInput.Get(OVRInput.RawButton.X) && (gc.actionStep == gc.stepsCount))
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

        if (gc.popupAllowed)
        {
            laserPointer.SetActive(true);
            Sphere.SetActive(true);
        }
        else
        {
            laserPointer.SetActive(false);
            Sphere.SetActive(false);
        }

        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp))
        {

            RightPopup.SetActive(false);
        }

        //if (OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        //{
        //    laserPointer.SetActive(true);
        //}
        //else
        //{
        //    laserPointer.SetActive(false);
        //}
    }
}
