using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public GameObject PopUp;
    public GameObject Buttons;
    public LadderFall_controll LadderAnimation;
    public bool GO=false;
    public QAFunctions qAFunctions;

    Question[] questions = new Question[10];

    // Start is called before the first frame update
    void Start()
    {
        Question test = new Question();
        for (int i =0; i < 10; i++)
        {
            questions[i] = new Question
            {
                questionText = qAFunctions.Q1
            };
        }
        Question Q1O = new Question
        {
            questionText = qAFunctions.Q1
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (GO)
        {
            QuestionButtons questionButtons = Buttons.GetComponent<QuestionButtons>();
            //questionButtons.DestroyChildren();
            questionButtons.SetUp(1);
            GO = false;
        }

    }
}
