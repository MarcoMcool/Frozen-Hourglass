using OVRTouchSample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointing: MonoBehaviour
{
    public Hand hand;
    public LineRenderer laserPointer;
    OVRInput.Controller activeController = OVRInput.GetActiveController();

    public Vector3 activeControllerPosition;
    // Start is called before the first frame update
    void Start()
    {
        laserPointer.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        activeControllerPosition = OVRInput.GetLocalControllerPosition(activeController);
        if (hand.m_isPointing || Input.GetKeyDown(KeyCode.L))
        {
            laserPointer.enabled = true;

            laserPointer.SetPosition(0, activeControllerPosition);
            laserPointer.SetPosition(1, activeControllerPosition + (Vector3.forward * 200f));

        }
        else
        {
            laserPointer.enabled = false;
        }
    }
}
