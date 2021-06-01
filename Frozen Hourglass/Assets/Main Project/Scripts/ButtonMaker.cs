using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMaker : MonoBehaviour
{
    public float BoxSpace = 0.55f;
    public float NumBoxs;
    // Start is called before the first frame update
    void Start()
    {
        SetUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUp()
    {
        for (int i =0; i< NumBoxs; i++)
        {
            Vector3 vector = new Vector3((BoxSpace * (NumBoxs-1))/2 - BoxSpace * i, 2.4f, 0f);
            Transform child= transform.GetChild(i);
            child.localPosition = vector;
 
        }
    }
}
