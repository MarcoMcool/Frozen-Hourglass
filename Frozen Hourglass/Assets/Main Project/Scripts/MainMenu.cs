using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   public void PLAY()
    {
        print("play has been pressed.");
        SceneManager.LoadScene(1);
    }
    
    public void QUIT()
    {
        print("quit game");
        Application.Quit();
    }

    public void MAINMENU()
    {
        print("play has been pressed.");
        SceneManager.LoadScene(0);
    }
}
