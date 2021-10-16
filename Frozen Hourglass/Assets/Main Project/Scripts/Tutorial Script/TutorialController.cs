using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialController : MonoBehaviour
{

    public GrabbingCubes grabCubes;

    public int steps = 0;


    public OVRPlayerController playerController;
    public GameObject teleportation;

    public GameObject backwall;
    public TextMeshProUGUI backWallText;
    // Start is called before the first frame update
    void Start()
    {
        playerController.enabled = false;
        teleportation.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (steps == 1)
        {
            backWallText.text = "The main way to move around the area is by teleporting. \n " +
                "To Teleport move the right joystick forwards. To continue teleport to the highlighted area";
        }
        if (steps == 2)
        {
            backwall.SetActive(false);
        }
    }

    public void NextTutorial()
    {
        steps++;
    }

    public void TurnOffJoystick()
    {
        GlobalVariables.joystickMovement = false;
    }
}
