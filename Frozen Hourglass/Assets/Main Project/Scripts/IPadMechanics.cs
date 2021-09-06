using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IPadMechanics : MonoBehaviour
{
    // Tasks for creating the IPad are as follows:
    // Allow the IPad to simulate calling functions - 
    // A way to get the Ipad to look like they can call a person is to create an interface that shows some kind of button that players can press to change 
    // what is seen to a screen that can call a person


    // Allow the Ipad to simulate photo taking functions

    // How to take a picture with the camera - 
    // Idea 1: Figure out how to turn the current image on the camera into a saved images or sprite
    // Idea 2: Freeze the camera and duplicate the camera still frozen and save it, then unfreeze the camera

    // Using the render texture from the camera, create a texture of the render to make an image

    // This is the best tutorial on how to make a camera to take photos: https://www.youtube.com/watch?v=d-56p770t0U
    //Texture2D image = new Texture2D(200, 200, TextureFormat.RGB24, false);
    //GetComponent<Camera>().Render();
    //RenderTexture.active = GetComponent<Camera>().targetTexture;
    //image.ReadPixels(new Rect(0, 0, 200, 200), 0, 0);
    
    public GameObject camera;

    public Material flash;

    //public Button takePicture;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pictureSnap();
    }

    public void calling()
    {
        // When the user tries to call a person, being when they get click to call a person,
        // they will see a calling screen for about four seconds which will then go to another screen
        // that looks like the call was answered, and a sound effect plays, sounding like someone mumbling.
    }

    public void pictureSnap()
    {
        // Instead of trying to do something hard like take a photo which we probably won't even use
        // I will instead freeze the camera for a second, and have a sound effect play to give the illusion 
        // of taking a picture instead, alterntively I can make it go white instead of a freeze.
        // Make timer

        camera.GetComponent<Image>().material = flash;

    }
}
