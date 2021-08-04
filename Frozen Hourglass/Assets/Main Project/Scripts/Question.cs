using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Question : MonoBehaviour
{
    private int NumberOfAns;
    private QuestionButtons questionButtons;
    public Question(GameObject buttons, int numberOfAns)
    {
        questionButtons = buttons.GetComponent<QuestionButtons>();
        NumberOfAns = numberOfAns;
        questionButtons.SetUp(NumberOfAns);
    }

    // Start is called before the first frame update
    void Start()
    {
        questionButtons.SetUp(NumberOfAns);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
