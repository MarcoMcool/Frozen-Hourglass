using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabTransforms : MonoBehaviour
{
    public GameObject hmd;
    public GameObject leftCont;
    public GameObject rightCont;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hmd              : " + hmd.transform.position);
        Debug.Log("Left Controller  : " + leftCont.transform.position);
        Debug.Log("Right Controller : " + rightCont.transform.position);
    }
}
