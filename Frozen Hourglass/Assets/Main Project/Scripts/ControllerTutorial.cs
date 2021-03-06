using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerTutorial: MonoBehaviour
{
    public TextMeshProUGUI text;
    public int step = 0;

    public Material aButton;
    public Material bButton;
    public Material xButton;
    public Material yButton;
    public Material gripButton;
    public Material triggerButton;
    public Material joystick;
    public Material defaultMaterial;

    public SkinnedMeshRenderer leftController;
    public SkinnedMeshRenderer rightController;
    // Start is called before the first frame update
    void Start()
    {
        rightController.material = defaultMaterial;
        leftController.material = defaultMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.Any) && step == 0)
        {
            text.text = "Pointing is a major part of the training Aid.\n to point hold down the trigger on either hand (the button your pointer finger is on).";
            step++;
        }
        if (step == 1)
        {
            rightController.material = joystick;
            leftController.material = joystick;
            if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger) || OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
            {
                text.text = "Nice! \n" +
                    "when holding down the trigger pressing A will select the highlighted question \n" +
                    "press the A button now. if unsure look at the model of the controller in front of you for where the buttons are";
                step++;
            }
        }
        if (step == 2)//  && (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger) || OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)))
        {
            rightController.material = aButton;
            leftController.material = defaultMaterial;
            if (OVRInput.GetDown(OVRInput.RawButton.A))
            {
                text.text = "Great work. \n" +
                    "now we'll try grabbing. On the controller where your middle, ring and pinkie fingers are, there is a button, this is the grip or grab button.\n" +
                    "Give it a press now.";
                step++;
            }
        }
        if (step == 3)
        {
            rightController.material = gripButton;
            leftController.material = gripButton;
            if (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
            {
                text.text = "Nice work. \n" +
                    "You will be required to move around the scene to complete different actions. \n" +
                    "There are two different ways to move. The first is teleporting, this can be done by moving the right joystick forwards.\n" +
                    "Try it now.";
                step++;
            }
        }

        if (step == 4)
        {
            rightController.material = joystick;
            leftController.material = defaultMaterial;
            if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp))
            {
                text.text = "well done. \n" +
                    "The other way to move is to use the left joystick, this will simulate walking.\n Be careful, if you get motionsick within VR please just teleport around the scene. \n" +
                    "Press any button to continue";
                step++;
            }
        }
        if (step == 5)
        {
            rightController.material = defaultMaterial;
            leftController.material = joystick;
            if ((OVRInput.GetDown(OVRInput.RawButton.LThumbstickDown) || OVRInput.GetDown(OVRInput.RawButton.LThumbstickUp) || OVRInput.GetDown(OVRInput.RawButton.LThumbstickLeft) || OVRInput.GetDown(OVRInput.RawButton.LThumbstickRight)))
            {
                {
                    text.text = "Thats it for the tutorial, there are some hints and help within the training aid. \n" +
                              "feel free to see which buttons are where on the model infront." +
                              "if you are ready turn around and select the play button.";
                }
            }
        }
    }

    public void ContinueTutorial()
    {
        step++;
    }
}
