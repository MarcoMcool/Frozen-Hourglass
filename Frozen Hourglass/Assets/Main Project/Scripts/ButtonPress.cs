using UnityEngine;
using UnityEngine.Events;

public class ButtonPress: MonoBehaviour
{
    [System.Serializable]
    public class ButtonEvent: UnityEvent { }
    public float pressLength = 0.2f;
    public bool pressed;
    public ButtonEvent downEvent;
    public int buttonNumber;

    public GameController gameController;

    public Vector3 startPos;
    Rigidbody rb;

    void Start()
    {
        startPos = transform.localPosition;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        float distance = Mathf.Abs(transform.localPosition.y - startPos.y);
        if (distance >= pressLength)
        {
            // Prevent the button from going past the pressLength
            transform.localPosition = startPos + new Vector3(0, -pressLength, 0); //new Vector3(transform.position.x, startPos.y - pressLength, transform.position.z);
            if (!pressed)
            {

                pressed = true;
                downEvent?.Invoke();
            }
        }
        else
        {
            // If we aren't all the way down, reset our press
            pressed = false;
        }

        // Prevent button from springing back up past its original position
        if (transform.localPosition.y > startPos.y)
        {
            transform.localPosition = startPos;
        }

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
        transform.localPosition = startPos;
        //print(buttonNumber);
        gameController.PressButton(buttonNumber);
        if (buttonNumber == 0)
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            //gameObject.SetActive(false);
        }
    }
}