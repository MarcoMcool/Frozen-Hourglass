using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RadioButtonScript: MonoBehaviour
{

    public Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        toggle.isOn = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleButton()
    {
        print(toggle.name + "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        if (toggle.isOn)
        {
            
            toggle.isOn = false;
            print("toggle is on");
        }
        else
        {
            toggle.isOn = true;
            print("toggle is off");
        }
    }
}
