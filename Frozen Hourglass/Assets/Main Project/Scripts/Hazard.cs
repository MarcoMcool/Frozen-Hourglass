using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public GameObject safe_zone_line;

    public OVRGrabbable grab;
    public GameController gc;
    public Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        grab = GetComponent<OVRGrabbable>();
        gc = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gc.stepsCount == 7)
        {
            grab.enabled = true;
        }
        else
        {
            grab.enabled = false;
        }
        safe_zone_line.SetActive(gameObject.GetComponent<OVRGrabbable>().isGrabbed);
    }
}
