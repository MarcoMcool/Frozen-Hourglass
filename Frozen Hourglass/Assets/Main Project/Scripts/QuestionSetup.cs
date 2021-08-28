using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSetup
{
    public static Question[] SetUp()
    {
        Question[] questions = new Question[11];

        questions[0] = new Question(
            "What was the incident that occurred?",
            new string[] { "A ladder fell on the electrical line causing a short circuit", "A worker has been electrocuted", "The electrical line snapped" },
            "Correct: It was indeed a ladder that fell onto the powerline",
            "Incorrect: The incident was a ladder fell onto the powerline",
            1
        );
        questions[1] = new Question(
            "Should work in the vicinity be stopped?",
            new string[] { "True", "False"},
            "Correct: Work should be stopped immediately in the area",
            "Incorrect: The answer is True, work should be halted immediately.",
            1
        );
        questions[2] = new Question(
            "Is there any potential risks in the environment?",
            new string[] { "There is another ladder.", "The bushes in the garden.", "The truck near the powerline." },
            "Correct: The other ladder poses a risk in shocking anyone if it also touches the powerline.",
            "Incorrect: The answer is the other ladder in the front of the house.",
            1
        );
        questions[3] = new Question(
            "Which option in the hierarchy of control would best suit solving this risk?",
            new string[] { "Elimination - Remove hazard from workplace", "Substitution - Replace the hazard with less hazardous condition or process",
                "Isolation - Isolate the hazard from people at the workplace"},
            "Correct! /nEliminating the potential hazard reduces the risk of any other incidents.",
            "Incorrect! /nEliminating the risk would reduce the risk of incidents occuring.",
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
