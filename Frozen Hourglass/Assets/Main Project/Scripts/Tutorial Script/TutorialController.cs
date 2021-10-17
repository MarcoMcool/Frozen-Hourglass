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
    public GameObject otherButton;
    public TextMeshProUGUI backWallText;

    public OVRPlayerController vRPlayerController;
    public SimpleCapsuleWithStickMovement simpleCapsuleWithStickMovement;
    public GameObject playerControllerObj;
    // Start is called before the first frame update
    void Start()
    {

        if (!GlobalVariables.joystickMovement)
        {
            simpleCapsuleWithStickMovement.enabled = true;
            vRPlayerController.enabled = false;
            if (!GetComponent<Rigidbody>())
            {
                playerControllerObj.AddComponent<Rigidbody>();
            }
        }
        playerController.enabled = false;
        teleportation.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (steps == 0)
        {
            print("here in step 0");
        }
        if (steps == 1)
        {
            print("here in step 1");
            backWallText.text = "The main way to move around the area is by teleporting. \n " +
                "To Teleport move the right joystick forwards. To continue teleport to the highlighted area";
            teleportation.SetActive(true);
            playerController.enabled = true;
        }
        if (steps == 2)
        {
            
        }
    }

    public void NextTutorial()
    {
        steps++;
    }

    public void TurnOffJoystick()
    {
        
        GlobalVariables.joystickMovement = false;
        otherButton.SetActive(false);
        steps++;
    }
}
