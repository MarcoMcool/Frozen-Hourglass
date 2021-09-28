using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IPadMechanics : MonoBehaviour
{
    public GameController gameController;

    public GameObject camera;
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

    // Update is called once per frame
    void Update()
    {
        //print(Vector3.Distance(gameObject.transform.position, ladder.transform.position));
        // Timer for flash
        flashTimer += Time.deltaTime;
        // Timer for call to start
        callTimer += Time.deltaTime;

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

    }

    public void CheckCalling(int num)
    {
        if (!calledWorkSupervisor && num ==1)
        {
            callText.text = "Calling Work Group Supervisor";

            calledWorkSupervisor = true;
        }
        else if (!calledSiteSupervisor && calledWorkSupervisor && num==2)
        {
            callText.text = "Calling Site Supervisor";

            calledSiteSupervisor = true;
        }
        else
        {
            // Turn this into a prompt
            print("Wrong Supervisor");
            return;
        }
        StartCoroutine(Call());
    }
    IEnumerator Call()
    {
        //Print the time of when the function is first called.
        print("Started Coroutine at timestamp : " + Time.time);
        callingScreen.SetActive(true);
        callScreen.SetActive(false);

        callTimeText.text = "Calling...";


        //yield on a new YieldInstruction that waits for 5 seconds.

        yield return new WaitForSeconds(9);

        callTimeText.text = "Talking";
        print("CAll Answered");
        gameController.stepsCount++;
        yield return new WaitForSeconds(4);
        print("Supervisor called");
        callingScreen.SetActive(false);
        callScreen.SetActive(true);

        //After we have waited 9 seconds print the time again.
        print("Finished Coroutine at timestamp : " + Time.time);
    }

    public void workSupervisorCalling(int num)
    {
        if (calledWorkSupervisor == false)
        {
            callingScreen.SetActive(true);
            callScreen.SetActive(false);
            callText.text = "Calling Work Group Supervisor";

            callTimer = 0;
            callAnswered = false;
            callTimeText.text = "Calling...";
            calledWorkSupervisor = true;
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
            calledSiteSupervisor = true;
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
        if (Vector3.Distance(gameObject.transform.position, ladder.transform.position) <= distanceToHazard)
        {
            print("Picture has been taken");
            gameController.stepsCount++;
        }
        else
        {
            // Have message displayed to prompt
            print("Get closer to the hazard and point camera to it");
        }
    }
}
