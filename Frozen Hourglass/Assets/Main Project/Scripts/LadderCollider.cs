using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<MoveObject>())
        {
            print("here");
        }
        if (other.gameObject.name == "MoveLadder")
        {
            print("ladder in correct area");
        }
        else if (other.gameObject.name == "Ladder")
        {
            //Needs warning popup telling the user not to move the original ladder until safe to do so

        }
    }
}
