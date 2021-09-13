using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController: MonoBehaviour
{

    public bool animationEnd;
    public GameObject PopUp;
    public GameObject ActionPopUp;
    public TextMeshProUGUI ActionText;

    public int buttonPressed;
    public int question = 0;

    public bool selectHazardsStage;
    public bool moveHazardsStage;

    public float timer = 0f;

    bool answerReceived;
    bool correctAnswer;
    int questionNumber = 0;
    public bool popupAllowed;

    public bool ladderCorrectPosition;

    public int numberObjectsHighlighted;

    Question[] q;

    [SerializeField]
    private bool[] steps = new bool[] { false, true, true, false, true, false, true, false, true, true, true, false, true, true, true, false, true, false };
    
    public int stepsCount = 0;

    [Header("Question Answer Variables")]
    public TextMeshProUGUI questionText;
    public GameObject answersOptions;
    public GameObject answerResponseObj;
    public TextMeshProUGUI answerResponseTxtCorrect;
    public TextMeshProUGUI answerResponseTxtIncorrect;
    public TextMeshProUGUI answer1;
    public TextMeshProUGUI answer2;
    public TextMeshProUGUI answer3;
    public GameObject number3;
    public GameObject buttons;
    public GameObject button3;

    public LadderPhysics Ladder;

    public int actionStep = 0;

    // Start is called before the first frame update
    void Start()
    {
        PopUp.SetActive(false);
        ActionPopUp.SetActive(false);

        q = QuestionSetup.SetUp();

        SetAnswers(q[questionNumber]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Ladder.done == true && animationEnd != true)
        {
            stepsCount++;
            PopUp.SetActive(true);
            animationEnd = true;
        }

        if (steps[stepsCount])
        {
            ActionPopUp.SetActive(false);
            popupAllowed = true;
            PopUp.SetActive(true);
            actionStep = stepsCount;
        }
        else
        {
            popupAllowed = false;
            PopUp.SetActive(false);
            //Action Steps in order:
            //Start, Stop work, Point Hazards, Move Hazards, Call Supervisor, Call Group Manager, Take Photos
            if (stepsCount != 0 && actionStep == stepsCount-1)
            {
                ActionPopUp.SetActive(true);
                if (stepsCount == 3)
                {
                    //Stop work
                    ActionText.text = "Grab the worker by the pole to tell him to stop working";
                }
                if (stepsCount == 5)
                {
                    //Point Hazards
                    ActionText.text = "Point out the Hazards by pressing B or Y on the controller";
                }
                if (stepsCount == 7)
                {
                    //Move Hazards
                    ActionText.text = "Move Hazards by grabbing them and moving them into the street";
                }
                if (stepsCount == 11)
                {
                    //Call Supervisor
                    ActionText.text = "Call Supervisor by using your iPad on your belt below you, press A to use your pointer to press the buttons";
                }
                if (stepsCount == 15)
                {
                    //Call Group Manager
                    ActionText.text = "Call Group Manager with your iPad";
                }
                if (stepsCount == 17)
                {
                    //Take Photos
                    ActionText.text = "Take Photos with your iPad";
                }

                //Stop loop
                actionStep++;
            }

            if (stepsCount == 5)
            {
                //if (selectHazardsStage)
                //{
                //    stepsCount++;
                //    selectHazardsStage = false;
                //}
            }
            
        }
    }

    public void PressButton(int buttonPressed)
    {
        print("Button hit: " + buttonPressed);
        if (buttonPressed == 0)
        {
            animationEnd = false;
            Ladder.StartFall();
            PopUp.SetActive(false);
            return;
        }
        if (q[questionNumber].key == buttonPressed)
        {
            answerResponseTxtCorrect.text = q[questionNumber].correct;
            answerResponseObj.SetActive(true);
            answersOptions.SetActive(false);
            buttons.SetActive(false);
            questionNumber++;
            StartCoroutine(WaitTimer_2());
            
        }
        else
        {
            answerResponseTxtCorrect.text = q[questionNumber].incorrect;
            answersOptions.SetActive(false);
            buttons.SetActive(false);
            answerResponseObj.SetActive(true);
            StartCoroutine(WaitTimer());
        }
    }
    public void QuestionOrdering()
    {
        if (answerReceived && correctAnswer)
        {
            answersOptions.SetActive(false);
            answerResponseObj.SetActive(false);
            questionNumber++;
            StartCoroutine(WaitTimer());
        }
        else if (answerReceived && !correctAnswer)
        {
            answerResponseObj.SetActive(true);
            StartCoroutine(WaitTimer());
        }
        else
        {
            answerResponseObj.SetActive(false);
        }
    }

    public void SetAnswers(Question question)
    {
        print(question.questionText);
        string[] _answer = question.answers;
        //TODO Make loop
        TextMeshProUGUI[] UIAnswers = new TextMeshProUGUI[] { answer1, answer2, answer3 };
        for (int i = 0; i < _answer.Length; i++)
        {
            UIAnswers[i].text = _answer[i];
        }

        questionText.text = question.questionText;
        answerResponseTxtCorrect.text = question.correct;
        answerResponseTxtIncorrect.text = question.incorrect;

        answersOptions.SetActive(true);
        buttons.SetActive(true);

        //TODO fix this hack
        if (_answer.Length < 3)
        {
            number3.SetActive(false);
            button3.SetActive(false);
            answer3.text = "";
        }
        else
        {
            button3.SetActive(true);
            number3.SetActive(true);
        }

        answerResponseObj.SetActive(false);
    }


    IEnumerator WaitTimer()
    {
        //Print the time of when the function is first called.
        print("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        answerReceived = false;
        correctAnswer = false;
        yield return new WaitForSeconds(5);
        SetAnswers(q[questionNumber]);
        //After we have waited 5 seconds print the time again.
        print("Finished Coroutine at timestamp : " + Time.time);
    }
    IEnumerator WaitTimer_2()
    {
        //Print the time of when the function is first called.
        print("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        answerReceived = false;
        correctAnswer = false;
        yield return new WaitForSeconds(5);
        SetAnswers(q[questionNumber]);
        //After we have waited 5 seconds print the time again.
        print("Finished Coroutine at timestamp : " + Time.time);
        stepsCount++;
    }
}