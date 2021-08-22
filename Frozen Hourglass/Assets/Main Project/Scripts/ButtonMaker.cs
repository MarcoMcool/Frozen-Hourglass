using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonMaker: MonoBehaviour
{
    public float BoxSpace = 0.55f;
    public float NumBoxs;
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
        SetUp();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetUp()
    {

        for (int i = 0; i < NumBoxs; i++)
        {

            Transform child1 = transform.GetChild(0);
            GameObject child2 = child1.transform.GetChild(1).gameObject;

            TextMeshPro textObj = child2.GetComponent<TextMeshPro>();
            int numw = i + 1;
            textObj.text = "Answer" + numw;

            Vector3 vector = new Vector3((BoxSpace * (NumBoxs - 1)) / 2 - BoxSpace * i, 2.4f, 0f);
            Transform child = transform.GetChild(i);
            child.localPosition = vector;

        }
    }

    public void SetAnswers(string[] _answer, string _question, string _answerResponseCorrect, string _answerResponseIncorrect)
    {
        answer1.text = _answer[0];
        answer2.text = _answer[1];
        answer3.text = _answer[2];

        questionText.text = _question;
        answerResponseTxtCorrect.text = _answerResponseCorrect;
        answerResponseTxtIncorrect.text = _answerResponseIncorrect;
    }

    public void ShowResponse()
    {

    }
}
