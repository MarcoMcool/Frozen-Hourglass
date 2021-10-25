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

    public GameObject[] grabCubes;
    public Vector3 cube1;
    public Vector3 cube2;
    public Vector3 cube3;
    public Vector3 cube4;

    private void Start()
    {
        cube1 = grabCubes[0].transform.position;
        cube2 = grabCubes[1].transform.position;
        cube3 = grabCubes[2].transform.position;
        cube4 = grabCubes[3].transform.position;
    }
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
            if (other.tag == "Cube" && other.gameObject != cubeCollided1)
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
