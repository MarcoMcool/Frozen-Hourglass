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
    //public GameObject button1;
    public ButtonMaker button1;
    public ButtonMaker button2;
    

    

    // Start is called before the first frame update
    void Start()
    {
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(false);

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
        if (!button1Pressed && !button2Pressed)
        {
            button1.NumBoxs = 3;
            button1.SetUp();
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
                button1.gameObject.SetActive(false);
                button2.gameObject.SetActive(true);

                button2.SetUp();
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
