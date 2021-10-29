using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionSetup
{
    public static Question[] SetUp()
    {
        Question[] questions = new Question[12];

        questions[0] = new Question(
            "What was the incident that occurred?",
            new string[] { "A ladder fell on the electrical line causing a short circuit", "A worker has been electrocuted", "The electrical line snapped" },
            "Correct! \nA ladder resting against the house has fallen onto the powerlines that were close by.\n As the ladder is conductive it has caused a short circuit.",
            "Incorrect: \nThe incident was a ladder fell onto the powerline.",
            1
        );
        questions[1] = new Question(
            "Should work in the vicinity be stopped?",
            new string[] { "Yes", "No"},
            "Correct: \nWork should be stopped immediately in the area.",
            "Incorrect: \nThe answer is Yes, work should be halted immediately.",
            1
        );
        questions[2] = new Question(
            "Is there any potential risks in the environment?",
            new string[] { "There is another ladder.", "The bushes in the garden.", "The truck near the powerline." },
            "Correct: \nThe other ladder poses a risk in shocking anyone if it also touches the powerline.",
            "Incorrect: \nThe answer is the other ladder in the front of the house.",
            1
        );
        questions[3] = new Question(
            "Which option in the hierarchy of control would best suit solving this risk?",
            new string[] { "Elimination - Remove hazard from workplace", "Substitution - Replace the hazard with less hazardous condition or process",
                "Isolation - Isolate the hazard from people at the workplace"},
            "Correct! \nEliminating the potential hazard reduces the risk of any other incidents.",
            "Incorrect! \nEliminating the risk would reduce the risk of incidents occuring.",
            1
        );
        questions[4] = new Question(
            "Should the emergency services be called?",
            new string[] { "Yes, to help the person that was injured in the incident.", "Yes, just in case someone may get injured later.", "No, there wasn't anyone who was injured." },
            "Correct! \nAs no one is hurt or in danger it is not required to call emergency services,",
            "Incorrect! \nThere isn't a need to call emergency services as no one is hurt and procedures should be in place to prevent any other incidents.",
            3
        );
        questions[5] = new Question(
            "Is it necessary to render assistance to anyone?",
            new string[] { "Yes, there are people in the house who need help.", "No, everyone has been ordered to a safe distance.", "Yes, there passersby that are next to the powerline." },
            "Correct! \nThe workers on site are all unhurt and at a safe distance, and anyone inside won't be in direct contact with the powerline.",
            "Incorrect! \nAll workers on site are a safe distance away from the powerline so there should be a need to assist anyone.",
            2
        );
        questions[6] = new Question(
            "Should the work group supervisor be contacted?",
            new string[] { "Yes, the group supervisor must be informed of any incident", "No, it was a small event and no one was hurt.", "No, there is no visable damage so everything is fine." },
            "Correct! \nThe work group supervisor should be informed if any incidents occur so to ensure everyones safety while working.",
            "Incorrect! \nThe work group supervisor must be contacted if there are any incidents that occur to the powerline.",
            1
        );
        questions[7] = new Question(
            "Has the control measure been implemented to prevent escalation of the situation?",
            new string[] { "Yes, a ladder was removed from the scene.", "No, the site has been left untouched to secure the situation.", "Yes, the ladder was substituted with a wooden ladder." },
            "Correct! \nThe elimination of the ladder earlier prevented any possible incidents from occuring.",
            "Incorrect! \nThe ladder was eliminated from the site earlier to prevent possible incidents from occuring.",
            1
        );
        questions[8] = new Question(
            "Has the site been left unaltered?",
            new string[] { "Yes, nothing has been removed from the site.", "No, a ladder was removed from the site.", "No, the workers were removed from the site." },
            "Correct: \nThe site as been altered to removed a hazardous ladder reducing the risk of further incidents.",
            "Incorrect: \nThe site has been altered, by removing the ladder from the site earlier.",
            2
        );
        questions[9] = new Question(
            "Does the work group manager need to be contacted to release the site?",
            new string[] { "Yes, the manager needs to be contacted to continue work.", "No, work on the site can commence if workers deem the site safe.", "No, the manager doesn't need to inspect the site to release the site." },
            "Correct! \nThe work groups manager's permission to release the site is needed after deeming the site safe again to continue work.",
            "Incorrect! \nIf the work group manager isn't contacted work cannot commence as it hasn't been deemed safe yet.",
            1
        );
        questions[10] = new Question(
            "Do photos and witness recollections need to be recorded?",
            new string[] { "Yes, photos and witness recollections need to be recorded.", "No, the incident wasn't signficant enough to be record.", "No, it isn't important to take photos and record witness statements." },
            "Correct! \nCollecting photos and witness recollections are an important part of documenting an incident for recording and future reviewing.",
            "Incorrect! \nIt is necessary to record photos and witness recollections for future reviewing of incidents.",
            1
        );
        questions[11] = new Question(
            "The End",
            new string[] { "This should not be here", "Oh no", "Pls" },
            "Correct! \nSend help",
            "Incorrect! \nIt is necessary to record photos and witness recollections for future reviewing of incidents.",
            1
        );

        return questions;
    }
}
