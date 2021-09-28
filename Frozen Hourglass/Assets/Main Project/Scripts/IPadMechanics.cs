using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IPadMechanics : MonoBehaviour
{
    public GameController gameController;

    public GameObject camera;
    public Camera cameraObj;
    public GameObject ladder;

    public Material flash;
    public Material cameraImage;

    public GameObject callingScreen;
    public GameObject callScreen;
    public Text callText;
    public Text callTimeText;

    private float flashTimer = 0;
    private float flashTime = 0.5f;

    private float callTimer = 0;
    private float callTime = 9;
    private bool callingWorkSupervisor = false;
    private bool callingSiteSupervisor = false;
    private bool callAnswered = false;
    private bool calledWorkSupervisor = false;
    private bool calledSiteSupervisor = false;

    private int distanceToHazard = 13;


    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        //print(Vector3.Distance(gameObject.transform.position, ladder.transform.position));
        // Timer for flash
        flashTimer += Time.deltaTime;
        // Timer for call to start
        callTimer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Y))
        {
            pictureSnap();
        }
        //print("Flash Time: " + flashTimer);

        // Change material to white then change it back to the camera
        if (flashTime >= flashTimer)
        {
            camera.GetComponent<Image>().material = flash;
        }
        else
        {
            camera.GetComponent<Image>().material = cameraImage;
        }

        // Change text when after X seconds
        if (callTime <= callTimer)
        {
            // Could try to increment
            callTimeText.text = "Talking";
            print("CAll Answered");
            callAnswered = true;
        }

        if ((callingWorkSupervisor == true || callingSiteSupervisor == true) && callAnswered == true)
        {
            print("Supervisor called");
            gameController.stepsCount++;
            callAnswered = false;
            callingWorkSupervisor = false;
            callingSiteSupervisor = false;
            if(callingWorkSupervisor == true)
            {
                calledWorkSupervisor = true;
            }
            if(callingSiteSupervisor == true)
            {
                calledSiteSupervisor = true;
            }
           
        }
    }

    public void workSupervisorCalling()
    {
        if (calledWorkSupervisor == false)
        {
            callingScreen.SetActive(true);
            callScreen.SetActive(false);
            callText.text = "Calling Work Group Supervisor";

            callTimer = 0;
            callAnswered = false;
            callTimeText.text = "Calling...";
            callingWorkSupervisor = true;
        }
        else
        {
            // Turn this into a prompt
            print("You shouldn't call the work supervisor again");
        }
    }

    public void siteSupervisorCalling()
    {
        if (calledSiteSupervisor == false)
        {
            callingScreen.SetActive(true);
            callScreen.SetActive(false);
            callText.text = "Calling Site Supervisor";

            callTimer = 0;
            callAnswered = false;
            callTimeText.text = "Calling...";
            callingSiteSupervisor = true;
        }
        else
        {
            // Turn this into a prompt
            print("You shouldn't call the site supervisor again");
        }
    }

    // Bind to the take picture button to activte
    public void pictureSnap()
    {
        flashTimer = 0;

        Vector3 objectVisible = cameraObj.WorldToViewportPoint(ladder.transform.position);

        if (objectVisible.x > 0 && objectVisible.x < 1 && objectVisible.y > 0 && objectVisible.y < 1)
        {
            print("the object was visible in the camera");
            gameController.stepsCount++;
        }
        else
        {
            // Have message displayed to prompt
            print("Make sure the object is visible in this picture");
        }
    }
}
