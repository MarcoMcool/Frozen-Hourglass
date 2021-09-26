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
    private float callTime = 4;

    private int distanceToHazard = 13;

    // Update is called once per frame
    void Update()
    {
        print(Vector3.Distance(gameObject.transform.position, ladder.transform.position));
        // Timer for flash
        flashTimer += Time.deltaTime;
        // Timer for call to start
        callTimer += Time.deltaTime;
    }

    public void workSupervisorCalling()
    {
        callingScreen.SetActive(true);
        callScreen.SetActive(false);
        callText.text = "Calling Work Group Supervisor";

        callTimer = 0;

        if (callTime <= callTimer)
        {
            //callTimeText.text = callTimer.ToString();
            callTimeText.text = "0";
            print("CAll Answered");
        }

        gameController.stepsCount++;
    }

    public void siteSupervisorCalling()
    {
        callingScreen.SetActive(true);
        callScreen.SetActive(false);
        callText.text = "Calling Site Supervisor";

        gameController.stepsCount++;
    }

    // Bind to the take picture button to activte
    public void pictureSnap()
    {
        flashTimer = 0;
        if (Vector3.Distance(gameObject.transform.position, ladder.transform.position) <= distanceToHazard)
        {
            print("Picture has been taken");
            //print("Flash Time: " + flashTimer);

            if (flashTime <= flashTimer && flashTime + flashTime >= flashTimer)
            {
                camera.GetComponent<Image>().material = flash;
            }
            else
            {
                camera.GetComponent<Image>().material = cameraImage;
            }

            gameController.stepsCount++;
        }
        else
        {
            print("Get closer to the hazard and point camera to it");
        }
    }

    // The main point of the iPad apart from making the phone calls and
}
