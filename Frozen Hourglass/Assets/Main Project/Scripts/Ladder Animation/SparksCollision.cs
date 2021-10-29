using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparksCollision: MonoBehaviour
{
    public AudioSource bangSound;
    public GameObject sparksObject;
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
        if (other.gameObject.tag == "PowerLine")
        {
          
            if (!bangSound.isPlaying)
            {
                bangSound.Play();
            }
            sparksObject.SetActive(true);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PowerLine")
        {
            sparksObject.transform.position = other.transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        sparksObject.SetActive(false);
    }
}
