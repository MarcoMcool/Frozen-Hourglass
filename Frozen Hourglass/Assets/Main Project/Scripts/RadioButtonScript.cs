using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RadioButtonScript: MonoBehaviour
{

    public Toggle toggle;
    GameController gameController;

    public int buttonNumber;
    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        toggle.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleButton()
    {
        if (toggle.isOn)
        {
            toggle.isOn = false;
        }
        else
        {
            toggle.isOn = true;
        }
    }

    public void TellGameControllerRadio()
    {
        gameController.PressButton(buttonNumber);
    }
}
