using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSetup
{
    public static Question[] SetUp()
    {
        Question[] questions = new Question[11];

        questions[0] = new Question(
            "What as the incident that occurred?",
            new string[] { "q1 response 1", "q1 response 2", "q1 response 3" },
            "q1 Correct",
            "q1 inCorrect",
            1
        );



        return questions;
    }
}
