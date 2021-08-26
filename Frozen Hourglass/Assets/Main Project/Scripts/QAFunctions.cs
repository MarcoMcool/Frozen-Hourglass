using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QAFunctions: MonoBehaviour
{
    // The idea is to only use one panel that the user will look at to answer all these questions
    // and since this will be a guided experience, it won't be necessary to create a complicated
    // system for the question and answers section.

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
    public string Q3Response1 = "There is another ladder.";
    public string Q3Response2 = "The bushes in the garden.";
    public string Q3Response3 = "The truck near the powerline.";
    public string Q3Correct = "Correct! /nThe other ladder poses a risk in shocking anyone if it also touches the powerline.";
    public string Q3InCorrect = "Incorrect! /nThe answer is the other ladder in the front of the house.";

    // Question 4
    [Header("Question 4")]
    public string Q4 = "Which option in the hierarchy of control would best suit solving this risk?";
    public string Q4Response1 = "Elimination - Remove hazard from workplace";
    public string Q4Response2 = "Substitution - Replace the hazard with less hazardous condition or process";
    public string Q4Response3 = "Isolation - Isolate the hazard from people at the workplace";
    public string Q4Response4 = "Engineering - Apply engineering controls to reduce or minimise the hazard ";
    public string Q5Response5 = "Administration - Change or make improvements in the way people work";
    public string Q6Response6 = "PPE - Protect workers with Personal Protective equipment";
    public string Q4Correct = "Correct! /nEliminating the potential hazard reduces the risk of any other incidents.";
    public string Q4InCorrect = "Incorrect! /nEliminating the risk would reduce the risk of incidents occuring.";

    // Question 5
    [Header("Question 5")]
    public string Q5 = "Should the emergency services be called?";
    public string Q5Response1 = "Yes, to help the person that was injured in the incident.";
    public string Q5Response2 = "Yes, just in case someone may get injured later.";
    public string Q5Response3 = "No, there wasn't anyone who was injured.";
    public string Q5Correct = "Correct! /nAs no one is hurt or in danger it is not required to call emergency services,";
    public string Q5InCorrect = "Incorrect! /nThere isn't a need to call emergency services as no one is hurt and procedures should be in place to prevent" +
        "any other incidents.";

    // Question 6
    [Header("Question 6")]
    public string Q6 = "Is it necessary to render assistance to anyone?";
    public string Q6Response1 = "Yes, there are people in the house who need help.";
    public string Q6Response2 = "No, everyone has been ordered to a safe distance.";
    public string Q6Response3 = "Yes, there passersby that are next to the powerline.";
    public string Q6Correct = "Correct! /nThe workers on site are all unhurt and at a safe distance, and anyone inside won't be in direct contact with the powerline.";
    public string Q6InCorrect = "Incorrect! /nAll workers on site are a safe distance away from the powerline so there should be a need to assist anyone.";

    // Question 7
    [Header("Question 7")]
    public string Q7 = "Should the work group supervisor be contacted?";
    public string Q7Response1 = "Yes, the group supervisor must be informed of any incident";
    public string Q7Response2 = "No, it was a small event and no one was hurt.";
    public string Q7Response3 = "No, there is no visable damage so everything is fine.";
    public string Q7Correct = "Correct! /nThe work group supervisor should be informed if any incidents occur so to ensure everyones safety while working.";
    public string Q7InCorrect = "Incorrect! /nThe work group supervisor must be contacted if there are any incidents that occur to the powerline.";

    // Question 8
    [Header("Question 8")]
    public string Q8 = "Has the control measure been implemented to prevent escalation of the situation?";
    public string Q8Response1 = "Yes, the ladder was eliminated from the scene to prevent anymore incidents from potentially occuring.";
    public string Q8Response2 = "No, the site has been left untouched to secure the situation.";
    public string Q8Response3 = "Yes, the ladder was substituted with a wooden ladder to prevent another incident from occuring.";
    public string Q8Correct = "Correct! /nThe elimination of the ladder earlier prevented any possible incidents from occuring.";
    public string Q8InCorrect = "Incorrect! /nThe ladder was eliminated from the site earlier to prevent possible incidents from occuring.";

    // Question 9
    [Header("Question 9")]
    public string Q9 = "Has the site been left unaltered?";
    public string Q9Response1 = "Yes, nothing has been removed from the site.";
    public string Q9Response2 = "No, a ladder was removed from the site,";
    public string Q9Response3 = "No, the workers were removed from the site.";
    public string Q9Correct = "q9 Correct";
    public string Q9InCorrect = "q9 inCorrect";

    // Question 10
    [Header("Question 10")]
    public string Q10 = "Should the work group manager been contacted to release the site?";
    public string Q10Response1 = "Yes, the work group manager's permission is needed to continue work on the site.";
    public string Q10Response2 = "No, work on the site can commence after deeming the site safe by the workers.";
    public string Q10Response3 = "No, the work group manager doesn't need to inspect the site to deem it safe and release the site.";
    public string Q10Correct = "Correct! /nThe work groups manager's permission to release the site is needed after deeming the site safe again to continue work.";
    public string Q10InCorrect = "Incorrect! /nIf the work group manager isn't contacted work cannot commence as it hasn't been deemed safe yet.";

    // Question 11
    [Header("Question 11")]
    public string Q11 = "Have photos and witness recollections been recorded?";
    public string Q11Response1 = "Yes, photos and witness recollections have been recorded to be reported and stored for furture recording";
    public string Q11Response2 = "No, the incident wasn't signficant enough to warrent photos and witness recollections to be record.";
    public string Q11Response3 = "No, it isn't important to take photos and record witness statements.";
    public string Q11Correct = "Correct! /nCollecting photos and witness recollections are an important part of documenting an incident for recording and future reviewing.";
    public string Q11InCorrect = "Incorrect! /nIt is necessary to record photos and witness recollections for future reviewing of incidents.";

}
