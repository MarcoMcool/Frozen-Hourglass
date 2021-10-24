using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu: MonoBehaviour
{

    bool start = false;
    public void PLAY()
    {
        print("play has been pressed.");
        start = true;
        //SceneManager.LoadScene(1);
    }

    public void Start()
    {
        StartCoroutine(LoadYourAsyncScene());
    }
    IEnumerator LoadYourAsyncScene()
    {

        yield return null;

        //Begin to load the Scene you specify
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(1);
        //Don't let the Scene activate until you allow it to
        asyncOperation.allowSceneActivation = false;
        Debug.Log("Pro :" + asyncOperation.progress);
        //When the load is still in progress, output the Text and progress bar
        while (!asyncOperation.isDone)
        {
            // Check if the load has finished
            if (asyncOperation.progress >= 0.9f)
            {
                if (start)
                {
                    //Activate the Scene
                    asyncOperation.allowSceneActivation = true;
                }
            }

            yield return null;
        }
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
