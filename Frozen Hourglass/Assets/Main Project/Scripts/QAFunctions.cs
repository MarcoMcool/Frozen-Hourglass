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
    [Header("Question 1")]
    public string Q1 = "What is the incident that occurred?";
    public string Q1Response1 = "A ladder fell on the electrical line causing a short circuit";
    public string Q1Response2 = "A worker has been electrocuted";
    public string Q1Response3 = "The electrical line snapped";
    public string Q1Correct = "Correct! /nA ladder resting against the house has fallen onto the powerlines that were close by./n As the ladder is conductive it has caused a short circuit.";
    public string Q1InCorrect = "Incorrect! /n An incident has occured so all work must be stopped.";

    // Question 2
    [Header("Question 2")]
    public string Q2 = "Should work in the vicinity be stopped?";
    public string Q2Response1 = "No work does not need to be stopped as no one was injured.";
    public string Q2Response2 = "No work does not need to be stopped as ";
    public string Q2Response3 = "Yes work should be stopped as an incident has occurred";
    public string Q2Correct = "Correct! /n All work should be stopped as an incident has occurred with powerlines.";
    public string Q2InCorrect = "Incorrect! /n Work should be stopped so the correct procedure can be followed.";

    // Question 3
    [Header("Question 3")]
    public string Q3 = "Is there any potential risks in the environment?";
    public string Q3Response1 = "q3 response 1";
    public string Q3Response2 = "q3 response 2";
    public string Q3Response3 = "q3 response 3";
    public string Q3Correct = "q3 Correct";
    public string Q3InCorrect = "q3 inCorrect";

    // Question 4
    [Header("Question 4")]
    public string Q4 = "Which option in the hierarchy of control would best suit solving this risk?";
    public string Q4Response1 = "q4 response 1";
    public string Q4Response2 = "q4 response 2";
    public string Q4Response3 = "q4 response 3";
    public string Q4Correct = "q4 Correct";
    public string Q4InCorrect = "q4 inCorrect";

    // Question 5
    [Header("Question 5")]
    public string Q5 = "Should the emergency services be called?";
    public string Q5Response1 = "q5 response 1";
    public string Q5Response2 = "q5 response 2";
    public string Q5Response3 = "q5 response 3";
    public string Q5Correct = "q5 Correct";
    public string Q5InCorrect = "q5 inCorrect";

    // Question 6
    [Header("Question 6")]
    public string Q6 = "Is it necessary to render assistance to anyone?";
    public string Q6Response1 = "q6 response 1";
    public string Q6Response2 = "q6 response 2";
    public string Q6Response3 = "q6 response 3";
    public string Q6Correct = "q6 Correct";
    public string Q6InCorrect = "q6 inCorrect";

    // Question 7
    [Header("Question 7")]
    public string Q7 = "Should the work group supervisor be contacted?";
    public string Q7Response1 = "q7 response 1";
    public string Q7Response2 = "q7 response 2";
    public string Q7Response3 = "q7 response 3";
    public string Q7Correct = "q7 Correct";
    public string Q7InCorrect = "q7 inCorrect";

    // Question 8
    [Header("Question 8")]
    public string Q8 = "Has the control measure been implemented to prevent escalation of the situation?";
    public string Q8Response1 = "q8 response 1";
    public string Q8Response2 = "q8 response 2";
    public string Q8Response3 = "q8 response 3";
    public string Q8Correct = "q8 Correct";
    public string Q8InCorrect = "q8 inCorrect";

    // Question 9
    [Header("Question 9")]
    public string Q9 = "Has the site been left unaltered?";
    public string Q9Response1 = "q9 response 1";
    public string Q9Response2 = "q9 response 2";
    public string Q9Response3 = "q9 response 3";
    public string Q9Correct = "q9 Correct";
    public string Q9InCorrect = "q9 inCorrect";

    // Question 10
    [Header("Question 10")]
    public string Q10 = "Has the work group manager been contacted to release the site?";
    public string Q10Response1 = "q10 response 1";
    public string Q10Response2 = "q10 response 2";
    public string Q10Response3 = "q10 response 3";
    public string Q10Correct = "q10 Correct";
    public string Q10InCorrect = "q10 inCorrect";

    // Question 11
    [Header("Question 11")]
    public string Q11 = "Have photos and witness recollections been recorded?";
    public string Q11Response1 = "q11 response 1";
    public string Q11Response2 = "q11 response 2";
    public string Q11Response3 = "q11 response 3";
    public string Q11Correct = "q11 Correct";
    public string Q11InCorrect = "q11 inCorrect";

}
