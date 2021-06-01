using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour
{
    public bool animationActivate;
    public bool animationEnd;

    public GameObject answersq1;
    public GameObject fullboxq1;
    public GameObject answersq2;
    public GameObject fullboxq2;
    public GameObject text1;
    public GameObject text2;

    public bool button1Pressed;
    public bool button2Pressed;

    public float timer = 0f;
    public ButtonMaker buttonMaker;

    

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (animationActivate)
        {

        }
        if (animationEnd)
        {

        }

        if (button1Pressed)
        {
            if (timer >= 5f)
            {
                text1.SetActive(false);
                fullboxq1.SetActive(false);
                answersq2.SetActive(true);
                text2.SetActive(true);
                button1Pressed = false;
                timer = 0f;
                buttonMaker.NumBoxs = 2;
                buttonMaker.SetUp();
            }
            answersq1.SetActive(false);
            fullboxq1.SetActive(true);
            timer += Time.deltaTime;
        }
        if (button2Pressed)
        {
            timer += Time.deltaTime;
            if (timer >= 3f)
            {

                answersq1.SetActive(false);
                fullboxq1.SetActive(false);
            }
        }
    }
}
