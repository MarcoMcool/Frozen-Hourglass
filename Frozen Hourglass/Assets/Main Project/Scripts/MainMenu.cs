using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
   public void PLAY()
    {
        print("play has been pressed.");
    }
    
    public void QUIT()
    {
        print("quit game");
        Application.Quit();
    }
}
