using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControllerTutorial: MonoBehaviour
{
    public TextMeshProUGUI text;
    int step = 0;
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
        if (step == 1 && (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger)) || (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)))
        {
            text.text = "Nice! \n" +
                "when holding down the trigger pressing A will select the highlighted question \n" +
                "try that now. if unsure look at the model of the controller in front of you.";
            step++;
        }
        if (step == 2 && ((OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger)) || (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) && OVRInput.GetDown(OVRInput.RawButton.A)))
        {
            text.text = "Great work. \n" +
                "now we'll try grabbing. On the controller where your middle, ring and pinkie fingers are, there is a button, this is the grip or grab button.\n" +
                "Give it a press now.";
            step++;
        }
        if (step == 3 && (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger)))
        {


        }
    }
}
