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
    private float time = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pictureSnap();
        print("The amoun of time the timer has been going for: " + timer);
        timer += Time.deltaTime;

        if(time + 0.5 <= timer)
        {
            camera.GetComponent<Image>().material = cameraImage;
        }
    }

    public void calling()
    {
        // When the user tries to call a person, being when they get click to call a person,
        // they will see a calling screen for about four seconds which will then go to another screen
        // that looks like the call was answered, and a sound effect plays, sounding like someone mumbling.
    }

    // Bind to the take picture button to activte
    public void pictureSnap()
    {
        print("Picture taking");
        
        // Timer for flash
        timer = 0;
        //time = 0.5f;
        

        if (time <= timer && time + 0.5 >= timer)
        {
            camera.GetComponent<Image>().material = flash;
        }
        //else
        //{
        //    camera.GetComponent<Image>().material = cameraImage;
        //}
    }
}
