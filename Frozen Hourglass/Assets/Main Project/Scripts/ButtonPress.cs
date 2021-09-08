using UnityEngine;
using UnityEngine.Events;

public class ButtonPress: MonoBehaviour
{
    [System.Serializable]
    public class ButtonEvent: UnityEvent { }

    public float pressLength;
    public bool pressed;
    public ButtonEvent downEvent;
    public Material buttonMaterial;
    //public GameObject button;
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
        // If our distance is greater than what we specified as a press
        // set it to our max distance and register a press if we haven't already
        //float distance = Mathf.Abs(transform.position.y - startPos.y);
        float distance = Mathf.Abs(transform.localPosition.y - startPos.y);
        if (distance >= pressLength)
        {
            // Prevent the button from going past the pressLength
            transform.localPosition = startPos + new Vector3(0,-pressLength,0); //new Vector3(transform.position.x, startPos.y - pressLength, transform.position.z);
            if (!pressed)
            {
                /*
                if (buttonNumber == 0)
                {
                    gameController.button1Pressed = true;
                    this.transform.parent.gameObject.SetActive(false);
                }
                if (buttonNumber == 1)
                {
                    gameController.button1Pressed = true;
                }
                if (buttonNumber == 2)
                {

                    gameController.button2Pressed = true;
                    gameController.button1Pressed = false;
                }
                */
                //GetComponent<MeshRenderer>().material = buttonMaterial;
                //QuestionButtons.ButtonPressed = buttonNumber;
                pressed = true;
                // If we have an event, invoke it
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
            transform.localPosition = startPos; //new Vector3(transform.position.x, startPos.y, transform.position.z);
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

        print(buttonNumber);
        gameController.PressButton(buttonNumber);
        if (buttonNumber == 0)
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            //gameObject.SetActive(false);
        }
    }
}