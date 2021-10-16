using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbingCubes: MonoBehaviour
{

    GameObject cubeCollided1;
    GameObject cubeCollided2;

    public int cubesInZone;

    public TutorialController tutorialController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (!cubeCollided1)
        {
            if (other.tag == "Cube")
            {
                cubeCollided1 = other.gameObject;
                cubesInZone++;
            }
        }
        else
        {
            if (other.tag == "Cube")
            {
                cubeCollided2 = other.gameObject;
                tutorialController.NextTutorial();
            }
        }
    }
}
