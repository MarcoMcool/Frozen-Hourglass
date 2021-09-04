using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointHazards : MonoBehaviour
{
    public int numberOfHazards;
    public int selectedHazards;
    public GameController gameController;

    public List<GameObject> objectsFound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.stepsCount != 5)
        {
            objectsFound.Clear();
        }

        if (gameController.stepsCount == 5 && numberOfHazards == objectsFound.Count)
        {
            gameController.stepsCount++;
        }
    }
}
