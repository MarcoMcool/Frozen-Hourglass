using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour
{
    public bool animationActivate;
    public bool animationEnd;
    public LadderFall_controll LadderAnimation;
    public GameObject PopUp;
    public BoxTeleport BoxTeleport;
    public GameObject answersq1;
    public GameObject fullboxq1;
    public GameObject answersq2;
    public GameObject fullboxq2;
    public GameObject fullboxq3;
    public GameObject text1;
    public GameObject text2;

    public bool button1Pressed;
    public bool button2Pressed;
    public int question =0;

    public float timer = 0f;
    //public GameObject button1;
    public ButtonMaker button1;
    public ButtonMaker button2;
    private bool done = false;


    public bool ladderCorrectPosition;
    bool moveLadderSequence;

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
        if (!LadderAnimation.playing && question == 1 && !done)
        {
            PopUp.SetActive(true);
            BoxTeleport.doTelport();
            done = true;
        }
        if (button1Pressed && question == 0)
        {
            LadderAnimation.fall = true;
            question = 1;
            button1Pressed = false;
        }
        if (!button1Pressed && !button2Pressed)
        {
            button1.NumBoxs = 3;
            button1.SetUp();
        }
        if (button1Pressed && question == 1)
        {
            answersq1.SetActive(false);
            fullboxq1.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= 5f)
            {
                text1.SetActive(false);
                fullboxq1.SetActive(false);
                answersq1.SetActive(false);
                answersq2.SetActive(true);
                text2.SetActive(true);
                button1Pressed = false;
                timer = 0f;
                button1.gameObject.SetActive(false);
                button2.gameObject.SetActive(true);
                question = 2;
                button2.SetUp();
            }
            
            
        }
        if (button2Pressed)
        {
            answersq2.SetActive(false);
            fullboxq2.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= 5f)
            {
                answersq2.SetActive(true);
                fullboxq2.SetActive(false);
                button2Pressed = false;
                timer = 0f;
            }
        }
        if (button1Pressed && question == 2)
        {
            answersq2.SetActive(false);
            fullboxq3.SetActive(true);
            timer += Time.deltaTime;
            if (timer >= 5f)
            {
                answersq2.SetActive(true);
                fullboxq3.SetActive(false);
                button1Pressed = false;
                timer = 0f;
            }
        }

        if (moveLadderSequence)
        {

        }
    }




}
