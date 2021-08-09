using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QAFunctions: MonoBehaviour
{
    // The idea is to only use one panel that the user will look at to answer all these questions
    // and since this will be a guided experience, it won't be necessary to create a complicated
    // system for the question and answers section.


    public string[] Question1 = new string[6];
    public string[] Question2 = new string[6];

    // Question 1
    public string Q1 = "What is the incident that occurred?";
    public string Q1Response1 = "q1 response 1";
    public string Q1Response2 = "q1 response 2";
    public string Q1Response3 = "q1 response 3";
    public string Q1Correct = "q1 Correct";
    public string Q1InCorrect = "q1 inCorrect";

    // Question 2
    public string Q2 = "Should work in the vicinity be stopped?";
    public string Q2Response1 = "q2 response 1";
    public string Q2Response2 = "q2 response 2";
    public string Q2Response3 = "q2 response 3";
    public string Q2Correct = "q2 Correct";
    public string Q2InCorrect = "q2 inCorrect";

    // Question 3
    public string Q3 = "Is there any potential risks in the environment?";
    public string Q3Response1 = "q3 response 1";
    public string Q3Response2 = "q3 response 2";
    public string Q3Response3 = "q3 response 3";
    public string Q3Correct = "q3 Correct";
    public string Q3InCorrect = "q3 inCorrect";

    // Question 4
    public string Q4 = "Which option in the hierarchy of control would best suit solving this risk?";
    public string Q4Response1 = "q4 response 1";
    public string Q4Response2 = "q4 response 2";
    public string Q4Response3 = "q4 response 3";
    public string Q4Correct = "q4 Correct";
    public string Q4InCorrect = "q4 inCorrect";

    // Question 5
    public string Q5 = "Should the emergency services be called?";
    public string Q5Response1 = "q5 response 1";
    public string Q5Response2 = "q5 response 2";
    public string Q5Response3 = "q5 response 3";
    public string Q5Correct = "q5 Correct";
    public string Q5InCorrect = "q5 inCorrect";

    // Question 6
    public string Q6 = "Is it necessary to render assistance to anyone?";
    public string Q6Response1 = "q6 response 1";
    public string Q6Response2 = "q6 response 2";
    public string Q6Response3 = "q6 response 3";
    public string Q6Correct = "q6 Correct";
    public string Q6InCorrect = "q6 inCorrect";

    // Question 7
    public string Q7 = "Should the work group supervisor be contacted?";
    public string Q7Response1 = "q7 response 1";
    public string Q7Response2 = "q7 response 2";
    public string Q7Response3 = "q7 response 3";
    public string Q7Correct = "q7 Correct";
    public string Q7InCorrect = "q7 inCorrect";

    // Question 8
    public string Q8 = "Has the control measure been implemented to prevent escalation of the situation?";
    public string Q8Response1 = "q8 response 1";
    public string Q8Response2 = "q8 response 2";
    public string Q8Response3 = "q8 response 3";
    public string Q8Correct = "q8 Correct";
    public string Q8InCorrect = "q8 inCorrect";

    // Question 9
    public string Q9 = "Has the site been left unaltered?";
    public string Q9Response1 = "q9 response 1";
    public string Q9Response2 = "q9 response 2";
    public string Q9Response3 = "q9 response 3";
    public string Q9Correct = "q9 Correct";
    public string Q9InCorrect = "q9 inCorrect";

    // Question 10
    public string Q10 = "Has the work group manager been contacted to release the site?";
    public string Q10Response1 = "q10 response 1";
    public string Q10Response2 = "q10 response 2";
    public string Q10Response3 = "q10 response 3";
    public string Q10Correct = "q10 Correct";
    public string Q10InCorrect = "q10 inCorrect";

    // Question 11
    public string Q11 = "Have photos and witness recollections been recorded?";
    public string Q11Response1 = "q11 response 1";
    public string Q11Response2 = "q11 response 2";
    public string Q11Response3 = "q11 response 3";
    public string Q11Correct = "q11 Correct";
    public string Q11InCorrect = "q11 inCorrect";

    public void Start()
    {
        Question1[0] = Q1;
        Question1[1] = Q1Response1;
        Question1[2] = Q1Response2;
        Question1[3] = Q1Response3;
        Question1[4] = Q1Correct;
        Question1[5] = Q1InCorrect;

        Question2[0] = Q2;
        Question2[1] = Q2Response1;
        Question2[2] = Q2Response2;
        Question2[3] = Q2Response3;
        Question2[4] = Q2Correct;
        Question2[5] = Q2InCorrect;
    }
}
