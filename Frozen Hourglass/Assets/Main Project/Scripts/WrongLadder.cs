using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WrongLadder : MonoBehaviour
{
    public GameObject rightHandPopup;
    public TextMeshProUGUI rightHandText;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "PlayerHands")
        {
            if (OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) || OVRInput.Get(OVRInput.Button.SecondaryHandTrigger)){
                rightHandPopup.SetActive(true);
                rightHandText.text = "This ladder is not a hazard that should be removed";
                StartCoroutine(WaitTime());
            }
        }
    }


    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(3f);
        rightHandPopup.SetActive(false);
        rightHandText.text = "";
    }
}
