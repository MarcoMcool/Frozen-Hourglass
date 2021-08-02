using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionButtons : MonoBehaviour
{
    public GameObject ButtonBox;
    public float BoxSpace = 0.4135f;
    public int ButtonPressed = -1;
    private Vector3 startPos;
    [SerializeField]
    private float NumBoxs;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        SetUp(4);
        //SetUp(4);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetUp(float numBoxs)
    {
        DestroyChildren();
        //transform.position = startPos;
        for (int i = 0; i < numBoxs; i++)
        {
            GameObject NewButton = Instantiate(ButtonBox, transform);
            // Make ButtonBox(i+1)
            Vector3 vector = new Vector3((BoxSpace * (numBoxs - 1)) / 2 - (BoxSpace * i), 2.4f, 0f);
            //Transform child = transform.GetChild(i);
            //child.localPosition = vector;

            NewButton.transform.localPosition = vector;

            ButtonPress button = NewButton.GetComponentInChildren<ButtonPress>();
            button.buttonNumber = i + 1;
        }
        NumBoxs = numBoxs;
    }
    public void DestroyChildren()
    {
        /*
        for (int i = 0; i < NumBoxs; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        */
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }
    }
}
