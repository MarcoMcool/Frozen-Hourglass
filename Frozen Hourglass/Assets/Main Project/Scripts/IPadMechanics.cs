using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IPadMechanics : MonoBehaviour
{
    public GameController gameController;

    public GameObject camera;

    public GameObject ladder;
    public GameObject iPad;
    public Camera cameraObj;

    public Material flash;
    public Material cameraImage;

    public GameObject callingScreen;
    public GameObject callScreen;
    public GameObject cameraMessage;
    public Text callText;
    public Text callTimeText;
    public AudioSource callAudio;
    public GameObject wrongCallPanel;
    public Text stopPhotos;

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
        if (!calledWorkSupervisor && num == 1)
        {
            callText.text = "Calling Work Group Supervisor";

            calledWorkSupervisor = true;
        }
        else if (!calledSiteSupervisor && calledWorkSupervisor && num == 2)
        {
            callText.text = "Calling Work Group Manager";

            calledSiteSupervisor = true;
        }
        else
        {
            // Turn this into a prompt
            print("Wrong Supervisor");
            wrongCallPanel.SetActive(true);
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
        callAudio.Play();

        //yield on a new YieldInstruction that waits for 9 seconds.

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

        //iPad.SetActive(false);
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
            print("You shouldn't call the work group supervisor again");
        }
    }

    public void siteSupervisorCalling()
    {
        if (calledSiteSupervisor == false)
        {
            callingScreen.SetActive(true);
            callScreen.SetActive(false);
            callText.text = "Calling Work Group Manager";

            callTimer = 0;
            callAnswered = false;
            callTimeText.text = "Calling...";
            calledSiteSupervisor = true;
        }
        else
        {
            // Turn this into a prompt
            print("You shouldn't call the Work Group Manager again");
        }
    }

    // Bind to the take picture button to activte
    public void pictureSnap()
    {
        flashTimer = 0;

        Vector3 objectVisible = cameraObj.WorldToViewportPoint(ladder.transform.position);
        if (gameController.stepsCount == 17)
        {


            if (objectVisible.x > 0 && objectVisible.x < 1 && objectVisible.y > 0 && objectVisible.y < 1)
            {
                stopPhotos.SetActive(true);
                print("the object was visible in the camera");
                gameController.stepsCount++;
            }
            else
            {
                // Have message displayed to prompt
                cameraMessage.SetActive(true);
                cameraMessage.GetComponentInChildren<Text>().text = "Make sure the object is visible in this picture. Click on message to remove!";
                print("Make sure the object is visible in this picture");
            }
        }
    }
    public Text notepadText;

    public void notepad()
    {
        notepadText.text = "Worker: The Ladder fell down and hit the wire.";
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        //Print the time of when the function is first called.
        //print("Started Coroutine at timestamp : " + Time.time);
        

        //yield on a new YieldInstruction that waits for 5 seconds.

        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        //print("Finished Coroutine at timestamp : " + Time.time);

        iPad.SetActive(false);
        gameController.stepsCount++;
    }
}
