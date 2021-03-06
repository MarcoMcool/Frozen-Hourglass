using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RadioButtonToGC: MonoBehaviour
{
    public Toggle toggle;
    public ToggleGroup toggleGroup;
    public Button continueButton;
    public TextMeshProUGUI buttonText;
    GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (toggleGroup.AnyTogglesOn())
        {
            continueButton.interactable = true;
            buttonText.color = Color.white;
        }
        else
        {
            continueButton.interactable = false;
            buttonText.color = Color.grey;
        }
    }

    

    public void ContinueButton()
    {
        toggle = toggleGroup.GetFirstActiveToggle();

        //print(toggle.name);
        int test = toggle.GetComponentInParent<RadioButtonScript>().buttonNumber;
        toggle.isOn = false;
        gameController.PressButton(test);
        //toggleGroup.SetAllTogglesOff();
    }
}
