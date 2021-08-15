using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Texture2D image = new Texture2D(200, 200, TextureFormat.RGB24, false);
        GetComponent<Camera>().Render();
        RenderTexture.active = GetComponent<Camera>().targetTexture;
        image.ReadPixels(new Rect(0, 0, 200, 200), 0, 0);
    }
}
