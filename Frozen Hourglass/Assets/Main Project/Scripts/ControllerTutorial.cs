using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerTutorial: MonoBehaviour
{
    public TextMeshProUGUI text;
    public int step = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.Any) && step == 0)
        {
            text.text = "Pointing is a major part of the training Aid.\n to point hold down the trigger on either hand (the button your pointer finger is on).";
            step++;
        }
        if (step == 1 && (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger) || OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)))
        {
            text.text = "Nice! \n" +
                "when holding down the trigger pressing A will select the highlighted question \n" +
                "try that now. if unsure look at the model of the controller in front of you for where the buttons are";
            step++;
        }
        if (step == 2 && ((OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger) || OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) && OVRInput.GetDown(OVRInput.RawButton.A)))
        {
            text.text = "Great work. \n" +
                "now we'll try grabbing. On the controller where your middle, ring and pinkie fingers are, there is a button, this is the grip or grab button.\n" +
                "Give it a press now.";
            step++;
        }
        if (step == 3 && OVRInput.GetDown(OVRInput.RawButton.RHandTrigger))
        {
            text.text = "Nice work. \n" +
                "You will be required to move around the scene to complete different actions. \n" +
                "There are two different ways to move. The first is teleporting, this can be done by moving the right joystick forwards.\n" +
                "Try it now.";
            step++;
        }

        if (step == 4 && OVRInput.GetDown(OVRInput.RawButton.RThumbstickUp))
        {
            text.text = "well done. \n" +
                "the other way to move is to use the left joystick, this will simulate walking.\n Be careful, if you get motionsick within VR please just teleport around the scene.";
            StartCoroutine(WaitTime());
        }
        if (step == 5)
        {
            text.text = "Thats it for the tutorial, there are some hints and help within the training aid. \n" +
                      "feel free to see which buttons are where on the model infront." +
                      "if you are ready turn around and select the play button.";
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(5f);
        step++;
    }
}
