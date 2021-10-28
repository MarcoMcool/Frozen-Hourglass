using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Controller : MonoBehaviour
{
    public IPadMechanics iPad;
    public Workers worker;
    public GameObject moveLadder;
    public GameObject ladder;
    public PointHazards pointHazard;
    public LadderCollider safeZone;
    public int max_Step =0;
    private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        max_Step = 0;
        gameController = GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Step_Reset(int step)
    {
        if(gameController.stepsCount > max_Step)
        {
            max_Step = gameController.stepsCount;
        }
        iPad.Reset_iPad(step);
        worker.Reset_Worker(step);
        if (step < 7)
        {
            ladder.transform.localPosition = Vector3.zero;
            ladder.transform.localRotation = Quaternion.identity;
            safeZone.objectsFound.Clear();
        }
        else
        {
            ladder.transform.localPosition = new Vector3(-0.170762539f, -0.00570999645f, 0.235542759f);
            ladder.transform.localRotation = new Quaternion(0.427658379f, -0.55748868f, -0.433087468f, 0.564579487f);
        }
        
    }
}
