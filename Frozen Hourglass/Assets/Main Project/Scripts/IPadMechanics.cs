using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IPadMechanics : MonoBehaviour
{  
    public GameObject camera;
    
    public Material flash;
    public Material cameraImage;

    private float timer = 0;
    private float time = 0.5f;

    public GameObject callingScreen;
    public GameObject callScreen;
    public GameController gameController;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pictureSnap();
    }

    public void CallingWorkGroup()
    {
        if (gameController.stepsCount == 11)
        {
            callingScreen.SetActive(true);
            callScreen.SetActive(false);
            StartCoroutine(WaitTimer());

            gameController.stepsCount++;
        }
        // When the user tries to call a person, being when they get click to call a person,
        // they will see a calling screen for about four seconds which will then go to another screen
        // that looks like the call was answered, and a sound effect plays, sounding like someone mumbling.

    }

    public void CallingSiteSupervisor()
    {
        if (gameController.stepsCount == 15)
        {
            callingScreen.SetActive(true);
            callScreen.SetActive(false);
            StartCoroutine(WaitTimer());

            gameController.stepsCount++;
        }
    }

    // Bind to the take picture button to activte
    public void pictureSnap()
    {        
        // Timer for flash
        timer += Time.deltaTime;

        if (time <= timer && time + 0.5 >= timer)
        {
            camera.GetComponent<Image>().material = flash;
        }
        else
        {
            camera.GetComponent<Image>().material = cameraImage;
        }

        if (gameController.stepsCount == 17)
        {
            gameController.stepsCount++;
        }
    }


    IEnumerator WaitTimer()
    {
        yield return new WaitForSeconds(3f);
    }
}
