using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IPadMechanics : MonoBehaviour
{
    public GameController gameController;

    public GameObject cameraObject;

    public GameObject ladder;
    public GameObject moveLadder;
    public GameObject iPad;
    public Camera cameraObj;

    public Material flash;
    public Material cameraImage;
    public GameObject mainScreen;
    public GameObject callingScreen;
    public GameObject callScreen;
    public GameObject notesScreen;
    public GameObject cameraMessage;
    public Text callText;
    public Text callTimeText;
    public AudioSource callAudio;
    public GameObject wrongCallPanel;
    public GameObject stopPhotos;

    private float flashTimer = 0;
    private float flashTime = 0.5f;

    private float callTimer = 0;
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
            cameraObject.GetComponent<Image>().material = flash;
        }
        else
        {
            cameraObject.GetComponent<Image>().material = cameraImage;
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
        
        yield return new WaitForSeconds(1);
        print("Supervisor called");
        callingScreen.SetActive(false);
        callScreen.SetActive(true);
        mainScreen.SetActive(true);
        callScreen.SetActive(false);
        cameraObject.SetActive(false);
        notesScreen.SetActive(false);
        gameController.stepsCount++;
        //After we have waited 9 seconds print the time again.
        print("Finished Coroutine at timestamp : " + Time.time);

        //iPad.SetActive(false);
    }

    // Bind to the take picture button to activte
    public int photosDone = 0;
    private bool moveLadderDone = false;
    private bool ladderDone = false;
    public void pictureSnap()
    {
        flashTimer = 0;

        Vector3 objectVisible = cameraObj.WorldToViewportPoint(ladder.transform.position);
        Vector3 moveObjectVisible = cameraObj.WorldToViewportPoint(moveLadder.transform.position);
        if (gameController.stepsCount == 17)
        {
            if (moveObjectVisible.x > 0 && moveObjectVisible.x < 1 && moveObjectVisible.y > 0 && moveObjectVisible.y < 1 && moveLadderDone == false)
            {
                print("the move ladder was visible in the camera");
                photosDone++;
                moveLadderDone = true;
            }
            else if (objectVisible.x > 0 && objectVisible.x < 1 && objectVisible.y > 0 && objectVisible.y < 1 && ladderDone == false)
            {
                print("the object was visible in the camera");
                photosDone++;
                ladderDone = true;
            }
            else
            {
                // Have message displayed to prompt
                cameraMessage.SetActive(true);
                cameraMessage.GetComponentInChildren<Text>().text = "Make sure the object is visible in this picture. Click on message to remove!";
                print("Make sure the object is visible in this picture");
            }
            if (photosDone == 2)
            {
                mainScreen.SetActive(true);
                callScreen.SetActive(false);
                cameraObject.SetActive(false);
                notesScreen.SetActive(false);
                gameController.stepsCount++;
            }
        }
        if (photosDone == 2)
        {
            stopPhotos.SetActive(true);
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
        mainScreen.SetActive(true);
        callScreen.SetActive(false);
        cameraObject.SetActive(false);
        notesScreen.SetActive(false);
        iPad.SetActive(false);
        iPad.GetComponent<Rigidbody>().useGravity = false;
        gameController.stepsCount++;
    }

    public GameObject saved_text;
    public void Reset_iPad(int step)
    {
        mainScreen.SetActive(true);
        callScreen.SetActive(false);
        cameraObject.SetActive(false);
        notesScreen.SetActive(false);


        if (step < 11)
        {
            calledWorkSupervisor = false;
            calledSiteSupervisor = false;
        }
        else if (step < 15)
        {
            calledWorkSupervisor = true;
            calledSiteSupervisor = false;
        }
        else
        {
            calledWorkSupervisor = true;
            calledSiteSupervisor = true;
        }
        if (step < 17)
        {
            photosDone = 0;
            moveLadderDone = false;
            ladderDone = false;
            saved_text.SetActive(false);
        }
        else
        {
            photosDone = 2;
            moveLadderDone = true;
            ladderDone = true;
        }
    }
}
