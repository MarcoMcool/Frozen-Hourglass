using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderCollider: MonoBehaviour
{
    public GameController gameController;
    public int numberOfHazards;

    public Hazard[] hazards;

    public List<GameObject> objectsFound;
    // Start is called before the first frame update
    void Start()
    {
        numberOfHazards = FindObjectsOfType<Hazard>().Length;
        hazards = FindObjectsOfType<Hazard>();
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

            print("object has hazard script");
            GameObject hazardObject;
            hazardObject = other.gameObject;
            if (objectsFound.Contains(hazardObject))
            {
                print("object in objects found");
                return;
            }
            else
            {
                print("hazard not in objects found");
                objectsFound.Add(hazardObject);

            }
            //gameController.ladderCorrectPosition = true;
            print("ladder in correct area");

            if (gameController.stepsCount == 7 && objectsFound.Count == numberOfHazards)
            {
                gameController.stepsCount++;
                print("correct time for the ladder");
            }
        }
        else if (other.gameObject.name == "Ladder")
        {
            gameController.ActionPopUp.SetActive(true);
            gameController.ActionText.text = "Do not touch this ladder. The scene should be quarantined.";
           
            //Needs warning popup telling the user not to move the original ladder until safe to do so

        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(3f);
        gameController.ActionPopUp.SetActive(false);
        gameController.ActionText.text = "";
    }
}
