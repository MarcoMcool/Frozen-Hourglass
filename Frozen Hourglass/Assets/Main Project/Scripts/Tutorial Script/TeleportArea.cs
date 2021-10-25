using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportArea : MonoBehaviour
{
    TutorialController tutController;
    void Start()
    {
        tutController = FindObjectOfType<TutorialController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //tutController.NextTutorial();
        }
    }
}
