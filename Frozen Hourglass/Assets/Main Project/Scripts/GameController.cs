using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController: MonoBehaviour
{
    public bool animationEnd;
    public GameObject PopUp;
    public GameObject ActionPopUp;
    public TextMeshProUGUI ActionText;
    public GameObject iPad;
    public GameObject endSequence;

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
    private bool[] steps = new bool[] { false, true, true, false, true, false, true, false, true, true, true, false, true, true, true, false, true, false, /*Talk*/ false, /*Record*/false, false };

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
    public GameObject buttons;
    public GameObject replay_button;


    [Header("YesNo Variables")]
    public TextMeshProUGUI yesNoAnswerResponse;
    public GameObject yesNoAnswerResponseObj;
    public GameObject yesNoButtons;
    public GameObject yesNoQuestions;
    public GameObject normalQuestions;
    public GameObject yesNoQuestionText;

    public LadderPhysics Ladder;

    public GameObject askWorker;
    public GameObject workerText;

    public int actionStep = 0;

    public OVRPlayerController vRPlayerController;
    public SimpleCapsuleWithStickMovement simpleCapsuleWithStickMovement;
    public GameObject playerControllerObj;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

        if (!GlobalVariables.joystickMovement)
        {
            //simpleCapsuleWithStickMovement.enabled = true;
            vRPlayerController.EnableLinearMovement = false;
            //playerControllerObj.AddComponent<Rigidbody>();
            //rb = playerControllerObj.GetComponent<Rigidbody>();
            //rb.constraints = RigidbodyConstraints.FreezeAll;

        }
        else
        {
            vRPlayerController.EnableLinearMovement = true;
        }
        //GoToQuestion(5);
        iPad.SetActive(false);
        PopUp.SetActive(false);
        ActionPopUp.SetActive(false);

        q = QuestionSetup.SetUp();
        q[questionNumber].ShuffleAnswers();
        SetAnswers(q[questionNumber]);
    }

    // Update is called once per frame
    void Update()
    {
        if (questionNumber > max_Question)
        {
            max_Question = questionNumber;
        }
        if (extra_Question_number == max_Question+1)
        {
            rightArrow.interactable = false;
        }
        else
        {
            rightArrow.interactable = true;
        }
        if (Ladder.done == true && animationEnd != true)
        {
            //stepsCount++;
            PopUp.SetActive(true);
            animationEnd = true;
            stepsCount++;
        }

        if (steps[stepsCount])
        {
            ActionPopUp.SetActive(false);
            popupAllowed = true;
            PopUp.SetActive(true);
            iPad.SetActive(false);
            replay_button.SetActive(stepsCount == 1);
            actionStep = stepsCount;
        }
        else
        {
            popupAllowed = false;
            PopUp.SetActive(false);
            //Action Steps in order:
            //Start, Stop work, Point Hazards, Move Hazards, Call Supervisor, Call Group Manager, Take Photos
            if (stepsCount != 0 && actionStep == stepsCount - 1)
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
                    ActionText.text = "Point out the Hazards by holding the trigger and pressing the A button on the controller";
                }
                if (stepsCount == 7)
                {
                    //Move Hazards
                    ActionText.text = "Move Hazards by grabbing them and moving them into the street safe zone";
                }
                if (stepsCount == 11)
                {
                    //Call Work Group Supervisor
                    iPad.SetActive(true);
                    ActionText.text = "Call Work Group Supervisor by using your iPad in front of you, press A to select icons on the iPad";
                }
                if (stepsCount == 15)
                {
                    //Call Site Supervisor
                    iPad.SetActive(true);
                    ActionText.text = "Call Work Group Supervisor Manager with your iPad";
                }
                if (stepsCount == 17)
                {
                    //Take Photos
                    iPad.SetActive(true);
                    ActionText.text = "Take Photos with your iPad";
                }
                if (stepsCount == 18)
                {
                    //iPad.SetActive(false);
                    askWorker.SetActive(true);
                    ActionText.text = "Ask the worker for witness recollections";
                }
                if (stepsCount == 19)
                {
                    ActionText.text = "Record the worker recollections on the iPad";
                    iPad.SetActive(true);
                    askWorker.SetActive(false);
                    workerText.SetActive(true);
                }
                // End of Experience Pop-up
                if (stepsCount == 20)
                {
                    workerText.SetActive(false);
                    endSequence.SetActive(true);
                }

                //Stop loop
                actionStep++;
            }

            // Hide prompt if user presses X
            if (OVRInput.GetDown(OVRInput.RawButton.X))
            {
                ActionPopUp.SetActive(false);
            }
        }
    }

    public void PressButton(int buttonPressed)
    {
        if (buttonPressed == 0)
        {
            stepsCount = 0;
            animationEnd = false;
            Ladder.StartFall();
            PopUp.SetActive(false);
            return;
        }

        if (buttonPressed == 4)
        {
            stepsCount++;
            return;
        }

        StartCoroutine(question_Handler(buttonPressed));

        //if (q[questionNumber].key == buttonPressed)
        //{
        //    //if the input is correct
        //    if (questionNumber == 1)
        //    {
        //        yesNoAnswerResponse.text = q[questionNumber].correct;
        //        yesNoAnswerResponseObj.SetActive(true);
        //        yesNoButtons.SetActive(false);
        //        yesNoQuestionText.SetActive(false);
        //        questionNumber++;
        //        StartCoroutine(WaitTimer_2());
        //    }
        //    else
        //    {
        //        answerResponseTxtCorrect.text = q[questionNumber].correct;
        //        answerResponseObj.SetActive(true);
        //        answersOptions.SetActive(false);
        //        //buttons.SetActive(false);
        //        questionNumber++;
        //        StartCoroutine(WaitTimer_2());
        //    }
        //}
        //else
        //{
        //    if (questionNumber == 1)
        //    {
        //        yesNoAnswerResponse.text = q[questionNumber].incorrect;
        //        yesNoAnswerResponseObj.SetActive(true);
        //        yesNoButtons.SetActive(false);

        //        StartCoroutine(WaitTimer());
        //    }
        //    else
        //    {
        //        answerResponseTxtCorrect.text = q[questionNumber].incorrect;
        //        answersOptions.SetActive(false);
        //        //buttons.SetActive(false);

        //        answerResponseObj.SetActive(true);
        //        StartCoroutine(WaitTimer());
        //    }
        //}
    }


    public void SetAnswers(Question question)
    {
        print(question.questionText +"\n"+ question.key);
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
        //buttons.SetActive(true);

        //TODO fix this hack
        if (_answer.Length < 3)
        {
            yesNoQuestions.SetActive(true);
            normalQuestions.SetActive(false);
            yesNoButtons.SetActive(true);
            yesNoQuestionText.SetActive(true);
        }
        else
        {
            yesNoQuestions.SetActive(false);
            normalQuestions.SetActive(true);
        }

        answerResponseObj.SetActive(false);
        yesNoAnswerResponseObj.SetActive(false);
    }


    IEnumerator WaitTimer()
    {
        answerReceived = false;
        correctAnswer = false;
        yield return new WaitForSeconds(5);
        yesNoQuestions.SetActive(false);
        SetAnswers(q[questionNumber]);
    }
    IEnumerator question_Handler(int buttonPressed)
    {
        correctAnswer = q[questionNumber].key == buttonPressed;
        string text = "";
        if (correctAnswer)
        {
            text = q[questionNumber].correct;
        }
        else
        {
            text = q[questionNumber].incorrect;
        }
        if (questionNumber == 1)
        {
            yesNoAnswerResponse.text = text;
            yesNoAnswerResponseObj.SetActive(true);
            yesNoButtons.SetActive(false);
            yesNoQuestionText.SetActive(false);
        }
        else
        {
            answerResponseTxtCorrect.text = text;
            answerResponseObj.SetActive(true);
            answersOptions.SetActive(false);
        }


        answerReceived = false;
        yield return new WaitUntil(test);
        //yield return new WaitForSeconds(5);
        if (correctAnswer)
        {
            stepsCount++;
            questionNumber++;
            q[questionNumber].ShuffleAnswers();
        }
        SetAnswers(q[questionNumber]);
    }
    public bool test()
    {
        return answerReceived;
    }
    public void nextQuestion()
    {
        answerReceived = true;
    }

    /* Section for extra menu*/
    [Header("Extra Menu Variables")]
    public TextMeshProUGUI Question_text;
    public TextMeshProUGUI Question_info;
    public Button leftArrow;
    public Button rightArrow;
    private int max_Question = 0;
    private int extra_Question_number = 1;
    public void Arrow_Button_Pressed(bool right)
    {
        if (right)
        {
            extra_Question_number++;
            Question_text.text = ("Question: " + extra_Question_number);
            Question_info.text = q[extra_Question_number-1].questionText;
            if (extra_Question_number > 1)
            {
                leftArrow.interactable = true;
            }
        }
        else
        {
            extra_Question_number--;
            Question_text.text = ("Question: " + extra_Question_number);
            Question_info.text = q[extra_Question_number-1].questionText;
            if(extra_Question_number == 1)
            {
                leftArrow.interactable = false;
            }
        }
    }
    public void GoToQuestion()
    {
        //Find right step
        int stepNum = 0;
        int tracker = 0;
        while (tracker != extra_Question_number)
        {
            stepNum++;
            if (steps[stepNum])
            {
                tracker++;
            }
            
        }
        //stepNum--;
        Reset_Controller Reseter = GetComponent<Reset_Controller>();

        Reseter.Step_Reset(stepNum);

        questionNumber = extra_Question_number-1;
        stepsCount = stepNum;
        q[questionNumber].ShuffleAnswers();
        SetAnswers(q[questionNumber]);
    }




}