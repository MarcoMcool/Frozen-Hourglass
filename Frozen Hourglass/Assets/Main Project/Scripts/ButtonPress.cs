using UnityEngine;
using UnityEngine.Events;

public class ButtonPress: MonoBehaviour
{
    [System.Serializable]
    public class ButtonEvent: UnityEvent { }

    public bool pressed;
    public ButtonEvent downEvent;
    public int buttonNumber;

    public GameController gameController;
    
    void Update()
    {
        if (Input.GetKeyDown("0") && buttonNumber == 0)
        {
            downEvent?.Invoke();
        }

        if (Input.GetKeyDown("l") && buttonNumber == 1)
        {
            downEvent?.Invoke();
        }
        if (Input.GetKeyDown("j") && buttonNumber == 2)
        {
            downEvent?.Invoke();
        }
        if (Input.GetKeyDown("k") && buttonNumber == 3)
        {
            downEvent?.Invoke();
        }
    }

    public void TellGameController()
    {
        print(buttonNumber);
        gameController.PressButton(buttonNumber);
        if (buttonNumber == 0)
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            //gameObject.SetActive(false);
        }
    }
}