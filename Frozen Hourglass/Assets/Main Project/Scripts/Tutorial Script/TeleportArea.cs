using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportArea : MonoBehaviour
{

    TutorialController tutController;
    // Start is called before the first frame update
    void Start()
    {
        tutController = FindObjectOfType<TutorialController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            tutController.NextTutorial();
        }
    }
}
