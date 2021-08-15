using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    public int buttonPressed;
    public int question = 0;

    public float timer = 0f;
    //public GameObject button1;
    public ButtonMaker button1;
    public ButtonMaker button2;
    private bool done = false;

    bool answerReceived;
    bool correctAnswer;
    int questionNumber = 0;

    public bool ladderCorrectPosition;
    bool moveLadderSequence;

    Question[] q;

    public TextMeshProUGUI questionText;
    public GameObject answersOptions;
    public GameObject answerResponseObjIncorrect;
    public GameObject answerResponseObjCorrect;
    public TextMeshProUGUI answerResponseTxtCorrect;
    public TextMeshProUGUI answerResponseTxtIncorrect;
    public TextMeshProUGUI answer1;
    public TextMeshProUGUI answer2;
    public TextMeshProUGUI answer3;
    // Start is called before the first frame update
    void Start()
    {
        q = QuestionSetup.SetUp();

        SetAnswers(q[questionNumber].answers, q[questionNumber].questionText, q[questionNumber].correct, q[questionNumber].incorrect);
    }

    // Update is called once per frame
    void Update()
    {
        QuestionOrdering();
    }

    public void PressButton(int buttonPressed)
    {
        if (q[questionNumber].key == buttonPressed)
        {
            answerResponseObjCorrect.SetActive(true);
        }
    }
    public void QuestionOrdering()
    {
        if (answerReceived && correctAnswer)
        {
            answersOptions.SetActive(false);
            answerResponseObjCorrect.SetActive(false);
            answerResponseObjIncorrect.SetActive(false);
            questionNumber++;
            StartCoroutine(WaitTimer());
        }
        else if(answerReceived && !correctAnswer)
        {
            answerResponseObjIncorrect.SetActive(true);
        }
        else
        {
            answerResponseObjIncorrect.SetActive(false);
            answerResponseObjCorrect.SetActive(false);
        }
    }

    public void SetAnswers(string[] _answer, string _question, string _answerResponseCorrect, string _answerResponseIncorrect)
    {

        print(_question);
        answer1.text = _answer[0];
        answer2.text = _answer[1];
        answer3.text = _answer[2];

        questionText.text = _question;
        answerResponseTxtCorrect.text = _answerResponseCorrect;
        answerResponseTxtIncorrect.text = _answerResponseIncorrect;
    }
    IEnumerator WaitTimer()
    {
        //Print the time of when the function is first called.
        print("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);
        SetAnswers(q[questionNumber].answers, q[questionNumber].questionText, q[questionNumber].correct, q[questionNumber].incorrect);
        //After we have waited 5 seconds print the time again.
        print("Finished Coroutine at timestamp : " + Time.time);
    }


}

//if (animationActivate)
//{

//}
//if (!LadderAnimation.playing && question == 1 && !done)
//{
//    PopUp.SetActive(true);
//    BoxTeleport.doTelport();
//    done = true;
//}
//if (button1Pressed && question == 0)
//{
//    LadderAnimation.fall = true;
//    question = 1;
//    button1Pressed = false;
//}
//if (!button1Pressed && !button2Pressed)
//{
//    button1.NumBoxs = 3;
//    button1.SetUp();
//}
//if (button1Pressed && question == 1)
//{
//    answersq1.SetActive(false);
//    fullboxq1.SetActive(true);
//    timer += Time.deltaTime;
//    if (timer >= 5f)
//    {
//        text1.SetActive(false);
//        fullboxq1.SetActive(false);
//        answersq1.SetActive(false);
//        answersq2.SetActive(true);
//        text2.SetActive(true);
//        button1Pressed = false;
//        timer = 0f;
//        button1.gameObject.SetActive(false);
//        button2.gameObject.SetActive(true);
//        question = 2;
//        button2.SetUp();
//    }


//}
//if (button2Pressed)
//{
//    answersq2.SetActive(false);
//    fullboxq2.SetActive(true);
//    timer += Time.deltaTime;
//    if (timer >= 5f)
//    {
//        answersq2.SetActive(true);
//        fullboxq2.SetActive(false);
//        button2Pressed = false;
//        timer = 0f;
//    }
//}
//if (button1Pressed && question == 2)
//{
//    answersq2.SetActive(false);
//    fullboxq3.SetActive(true);
//    timer += Time.deltaTime;
//    if (timer >= 5f)
//    {
//        answersq2.SetActive(true);
//        fullboxq3.SetActive(false);
//        button1Pressed = false;
//        timer = 0f;
//    }
//}

//if (moveLadderSequence)
//{

//}