using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Question
{
    public string questionText;
    public string[] answers;
    public string correct;
    public string incorrect;
    public int key;
    public Question(string _questionText, string[] _answers, string _correct, string _incorrect, int _key)
    {
        questionText = _questionText;
        answers = _answers;
        correct = _correct;
        incorrect = _incorrect;
        key = _key;
    }
    public Question()
    {

    }
    public string checkAnswer(int ans)
    {
        if (ans == key)
        {
            return correct;
        }
        else
        {
            return incorrect;
        }
    }
}

