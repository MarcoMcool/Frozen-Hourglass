using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepIncrement : MonoBehaviour
{
    public TutorialController tutorialController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print("Tutorial step is: " + tutorialController.steps);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tutorialController.audioPlay();
        }
    }
}