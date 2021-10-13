using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RadioButtonToGC: MonoBehaviour
{
    public ToggleGroup toggleGroup;
    public Button continueButton;
    public TextMeshProUGUI buttonText;
    // Start is called before the first frame update
    void Start()
    {

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
}
