using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrabbingCubes: MonoBehaviour
{
    GameObject cubeCollided1;
    GameObject cubeCollided2;

    public int cubesInZone = 0;

    public TutorialController tutorialController;
    public TextMeshPro cubeText;

    private void OnTriggerEnter(Collider other)
    {
        if (!cubeCollided1)
        {
            if (other.tag == "Cube")
            {
                cubeCollided1 = other.gameObject;
                cubesInZone++;
                cubeText.text = "cubes in zone = " + 1 + "/2";
                print("Cube first in the collider");
            }
        }
        else
        {
            if (other.tag == "Cube")
            {
                cubesInZone++;
                cubeCollided2 = other.gameObject;
                print("cube Second in collider");
                cubeText.text = "cubes in zone = " + 2 + "/2";
                if (cubesInZone == 2)
                {
                    tutorialController.NextTutorial();
                }
            }
        }
    }
}
