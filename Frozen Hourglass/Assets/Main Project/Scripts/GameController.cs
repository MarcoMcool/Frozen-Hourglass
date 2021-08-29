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

    public int buttonPressed;
    public int question = 0;
    public enum stage
    {
        Animation,
        Question,
        Response,
        Action,
        Other
    }

    public bool stopWorkStage;
    public bool selectHazardsStage;
    public bool moveHazardsStage;
    public bool callSupervisor;
    public bool callManager;
    public bool pictureTaken;

    public stage QuestionStage;

    public float timer = 0f;
    public ButtonMaker button1;
    public ButtonMaker button2;
    private bool done = false;

    bool answerReceived;
    bool correctAnswer;
    int questionNumber = 0;
    public bool popupAllowed;

    public bool ladderCorrectPosition;

    public int numberObjectsHighlighted;

    Question[] q;

    bool[] steps = new bool[] { true, false, true, true, false, true, false, true, true, true, false, true, true, true, false, true, false };
    int stepsCount = 0;

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

    // Start is called before the first frame update
    void Start()
    {
        PopUp.SetActive(false);
        //button1.gameObject.SetActive(true);
        //button2.gameObject.SetActive(false);

        q = QuestionSetup.SetUp();

        SetAnswers(q[questionNumber]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Ladder.done == true && animationEnd != true)
        {
            PopUp.SetActive(true);
            animationEnd = true;
        }

        if (steps[stepsCount])
        {
            popupAllowed = true;
            PopUp.SetActive(true);
        }
        else
        {
            popupAllowed = false;
            PopUp.SetActive(false);
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
            stepsCount++;
            return;
        }
        if (q[questionNumber].key == buttonPressed)
        {
            answerResponseTxtCorrect.text = q[questionNumber].correct;
            answerResponseObj.SetActive(true);
            answersOptions.SetActive(false);
            buttons.SetActive(false);
            questionNumber++;
            stepsCount++;
            StartCoroutine(WaitTimer());
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
}