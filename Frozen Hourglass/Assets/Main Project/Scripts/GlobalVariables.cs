using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{

    public static bool joystickMovement;

    public static bool JoystickMovement
    {
        get
        {
            return joystickMovement;
        }
        set
        {
            joystickMovement = value;
        }
    }

}
