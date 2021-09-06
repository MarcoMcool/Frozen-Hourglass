using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderCollider : MonoBehaviour
{
    public GameController gameController;
    public int numberOfHazards;
    int hazardsMoved;
    // Start is called before the first frame update
    void Start()
    {
        numberOfHazards = FindObjectsOfType<Hazard>().Length;
        gameController = FindObjectOfType<GameController>();
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
        if (other.gameObject.GetComponent<Hazard>())
        {
            //gameController.ladderCorrectPosition = true;
            print("ladder in correct area");

            if (gameController.stepsCount == 7 && hazardsMoved == numberOfHazards)
            {
                gameController.stepsCount++;
                print("correct time for the ladder");
            }
        }
        else if (other.gameObject.name == "Ladder")
        {
            //Needs warning popup telling the user not to move the original ladder until safe to do so

        }
    }
}
