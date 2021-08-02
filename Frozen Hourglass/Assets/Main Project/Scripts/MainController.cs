using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public GameObject PopUp;
    public GameObject Buttons;
    public LadderFall_controll LadderAnimation;
    public bool GO=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GO)
        {
            QuestionButtons questionButtons = Buttons.GetComponent<QuestionButtons>();
            //questionButtons.DestroyChildren();
            questionButtons.SetUp(1);
            GO = false;
        }

    }
}
