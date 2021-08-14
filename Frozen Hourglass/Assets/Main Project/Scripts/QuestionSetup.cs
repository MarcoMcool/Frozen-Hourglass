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
        questions[1] = new Question(
            "Should work in the vicinity be stopped?",
            new string[] { "q2 response 1", "q2 response 2", "q2 response 3" },
            "q2 Correct",
            "q2 inCorrect",
            1
        );
        questions[2] = new Question(
            "Is there any potential risks in the environment?",
            new string[] { "q3 response 1", "q3 response 2", "q3 response 3" },
            "q3 Correct",
            "q3 inCorrect",
            1
        );
        questions[3] = new Question(
            "Which option in the hierarchy of control would best suit solving this risk?",
            new string[] { "q4 response 1", "q4 response 2", "q4 response 3" },
            "q4 Correct",
            "q4 inCorrect",
            1
        );
        questions[4] = new Question(
            "Should the emergency services be called?",
            new string[] { "q5 response 1", "q5 response 2", "q5 response 3" },
            "q5 Correct",
            "q5 inCorrect",
            1
        );
        questions[5] = new Question(
            "Is it necessary to render assistance to anyone?",
            new string[] { "q6 response 1", "q6 response 2", "q6 response 3" },
            "q6 Correct",
            "q6 inCorrect",
            1
        );
        questions[6] = new Question(
            "Should the work group supervisor be contacted?",
            new string[] { "q7 response 1", "q7 response 2", "q7 response 3" },
            "q1 Correct",
            "q1 inCorrect",
            1
        );
        questions[7] = new Question(
            "Has the control measure been implemented to prevent escalation of the situation?",
            new string[] { "q1 response 1", "q1 response 2", "q1 response 3" },
            "q1 Correct",
            "q1 inCorrect",
            1
        );
        questions[8] = new Question(
            "Has the site been left unaltered?",
            new string[] { "q1 response 1", "q1 response 2", "q1 response 3" },
            "q1 Correct",
            "q1 inCorrect",
            1
        );
        questions[9] = new Question(
            "Has the work group manager been contacted to release the site?",
            new string[] { "q1 response 1", "q1 response 2", "q1 response 3" },
            "q1 Correct",
            "q1 inCorrect",
            1
        );
        questions[10] = new Question(
            "Have photos and witness recollections been recorded?",
            new string[] { "q1 response 1", "q1 response 2", "q1 response 3" },
            "q1 Correct",
            "q1 inCorrect",
            1
        );



        return questions;
    }
}
