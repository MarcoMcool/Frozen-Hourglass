using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IPadMechanics : MonoBehaviour
{  
    public GameObject camera;
    
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

    // Update is called once per frame
    void Update()
    {
        pictureSnap();
    }

    public void workSupervisorCalling()
    {
        callingScreen.SetActive(true);
        callScreen.SetActive(false);
        callText.text = "Calling Work Group Supervisor";

        // Timer for call to start
        callTimer += Time.deltaTime;

        if (callTime <= callTimer)
        {
            //callTimeText.text = callTimer.ToString();
            callTimeText.text = "0";
            print("CAll Answered");
        }
    }

    public void siteSupervisorCalling()
    {
        callingScreen.SetActive(true);
        callScreen.SetActive(false);
        callText.text = "Calling Site Supervisor";
    }

    // Bind to the take picture button to activte
    public void pictureSnap()
    {
        // Timer for flash
        flashTimer += Time.deltaTime;

        print("Flash Time: " + flashTimer);

        if (flashTime <= flashTimer && flashTime + 0.5 >= flashTimer)
        {
            camera.GetComponent<Image>().material = flash;
        }
        else
        {
            camera.GetComponent<Image>().material = cameraImage;
        }
    }
}
