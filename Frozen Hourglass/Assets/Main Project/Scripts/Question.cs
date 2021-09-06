
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Question
{
    public string questionText;
    private string[] givenAnswers;
    public string[] answers;
    public string correct;
    public string incorrect;
    public int key;
    public int givenKey;
    public Question(string _questionText,string[] _answers , string _correct, string _incorrect , int _key)
    {
        questionText = _questionText;
        givenAnswers = _answers;
        answers = _answers;
        correct = _correct;
        incorrect = _incorrect;
        givenKey = _key;
        key = _key;

    }

    public void ShuffleAnswers()
    {
        if (answers.Length == 2)
        {
            return;
        }
        int newKey = Random.Range(1, answers.Length);
        answers = givenAnswers;
        answers[newKey] = givenAnswers[givenKey];
        answers[givenKey] = givenAnswers[newKey];
        key = newKey;
    }

    public bool checkAnswer(int ans)
    {
        if (ans == key)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
