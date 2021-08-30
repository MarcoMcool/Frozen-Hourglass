using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointHazards : MonoBehaviour
{
    public int numberOfHazards;
    public int selectedHazards;
    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfHazards == selectedHazards)
        {
            gameController.selectHazardsStage = true;
        }
    }
}
