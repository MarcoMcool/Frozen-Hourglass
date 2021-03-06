using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialController: MonoBehaviour
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

    public GameObject[] wallPositions;
    public GameObject wall;

    public TextMeshPro blueCube;
    public TextMeshProUGUI blueCubeCanvas;
    public GameObject teleportFloor;

    public AudioSource audio1;
    public AudioSource audio2;
    public AudioSource audio3;
    public AudioSource audio4;
    public AudioSource audio5;

    public GameObject triggerZone1;
    public GameObject triggerZone2;
    public GameObject triggerZone3;

    public bool playAudio = false;

    void Start()
    {
        playerController.enabled = false;
        teleportation.SetActive(false);
        audio1.Stop();
        audio2.Stop();
        audio3.Stop();
        audio4.Stop();
        audio5.Stop();
    }

    void Update()
    {
        if (steps == 0)
        {
            //if (playAudio)
            //{
            //    if (!audio2.isPlaying)
            //    {
            //        audio2.Play();
            //    }
            //    audio1.Stop();
            //    audio3.Stop();
            //    audio4.Stop();
            //    audio5.Stop();
            //}
        }
        if (steps == 1)
        {
            //if (!audio2.isPlaying)
            //{
            //    audio2.Play();
            //}
            //audio1.Stop();
            //audio3.Stop();
            //audio4.Stop();
            //audio5.Stop();
            wall.transform.position = wallPositions[1].transform.position;
            print("here in step 1");
            backWallText.fontSize = 3;
            backWallText.text = "The main way to move around the area is by teleporting. \n\n " +
                "To Teleport, move the right joystick forwards, to rotate move the right joystick left or right.";
            teleportation.SetActive(true);
            playerController.enabled = true;
        }
        if (steps == 2)
        {
            //if (!audio3.isPlaying)
            //{
            //    audio3.Play();
            //}
            //audio1.Stop();
            //audio2.Stop();
            //audio4.Stop();
            //audio5.Stop();
            wall.transform.position = wallPositions[2].transform.position;
        }
        if(steps == 3)
        {
            triggerZone1.SetActive(false);
        }
        if (steps == 4)
        {
            //if (!audio4.isPlaying)
            //{
            //    audio4.Play();
            //}
            //audio1.Stop();
            //audio2.Stop();
            //audio3.Stop();
            //audio5.Stop();
            wall.transform.position = wallPositions[3].transform.position;
            triggerZone2.SetActive(false);
        }

        if (steps == 5)
        {
            //if (!audio5.isPlaying)
            //{
            //    audio5.Play();
            //}
            //audio1.Stop();
            //audio2.Stop();
            //audio3.Stop();
            //audio4.Stop();
            wall.SetActive(false);
            //wall.transform.position = wallPositions[2].transform.position;
            teleportFloor.SetActive(true);
            blueCube.text = "Nice Work!";
            blueCubeCanvas.text = "If you feel ready to progress turn to your right and select start.";
            triggerZone3.SetActive(false);
        }
    }

    public void audioPlay()
    {
        if(steps == 0)
        {
            audio1.Play();
            audio2.Stop();
            audio3.Stop();
            audio4.Stop();
            audio5.Stop();
        }
        if (steps == 1)
        {
            audio2.Play();
            audio1.Stop();
            audio3.Stop();
            audio4.Stop();
            audio5.Stop();
        }
        if (steps == 2)
        {
            audio3.Play();
            audio2.Stop();
            audio1.Stop();
            audio4.Stop();
            audio5.Stop();
        }
        if (steps == 3)
        {
            audio4.Play();
            audio2.Stop();
            audio3.Stop();
            audio1.Stop();
            audio5.Stop();
        }
        if (steps == 4)
        {
            audio5.Play();
            audio2.Stop();
            audio3.Stop();
            audio4.Stop();
            audio1.Stop();
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
    public void TurnOnJoystick()
    {
        GlobalVariables.joystickMovement = true;
        otherButton.SetActive(false);
        steps++;
    }

    public void JoystickSet()
    {
        if (!GlobalVariables.joystickMovement)
        {
            //simpleCapsuleWithStickMovement.enabled = true;
            vRPlayerController.EnableLinearMovement = false;
        }
        else
        {
            //simpleCapsuleWithStickMovement.enabled = true;
            vRPlayerController.EnableLinearMovement = true;
        }
    }

    public void StartTutorial()
    {
        //playAudio = true;
    }
}
