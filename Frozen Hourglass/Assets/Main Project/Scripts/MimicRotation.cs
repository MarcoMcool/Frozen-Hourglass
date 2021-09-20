using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicRotation : MonoBehaviour
{
    [SerializeField]
    public GameObject rightControllerModel;
    public GameObject leftControllerModel;
    public GameObject rightController;
    public GameObject leftController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rightControllerModel.transform.rotation = rightController.transform.rotation;
        leftControllerModel.transform.rotation = leftController.transform.rotation;
    }
}
