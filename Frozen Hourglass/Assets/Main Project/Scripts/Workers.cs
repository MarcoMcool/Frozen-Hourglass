using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workers: MonoBehaviour
{
    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(5, 1.006f, -2.415f);
        Vector3 startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (gameController.stepsCount == 3)
        {
            
            if (gameObject.GetComponent<OVRGrabbable>().isGrabbed || Input.GetKeyDown(KeyCode.M))
            {
                gameController.stepsCount++;
                // Move worker to a distance away from house
                if (Vector3.Distance(transform.position, new Vector3(10, transform.position.y, transform.position.z)) <= 5)
                {
                    transform.position += new Vector3(3, 0, 0) * Time.deltaTime;
                }
            }
            //gameObject.SetActive(false);
        }
    }



    //void OnTriggerEnter(Collider other)
    //{
    //    if(other.tag == "PlayerHands")
    //    {
    //        if (worker1.GetComponent<OVRGrabbable>().isGrabbed)
    //        {
    //            worker1.SetActive(false);
    //        }
    //    }
    //}
}
