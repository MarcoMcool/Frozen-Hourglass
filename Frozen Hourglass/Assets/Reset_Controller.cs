using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset_Controller : MonoBehaviour
{
    public IPadMechanics iPad;
    public Workers worker;
    public GameObject ladder;
    public PointHazards pointHazard;
    public LadderCollider safeZone;
    public int max_Question =0;
    // Start is called before the first frame update
    void Start()
    {
        max_Question = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Step_Reset(int step)
    {

    }
}
