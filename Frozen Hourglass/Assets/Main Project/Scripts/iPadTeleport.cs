using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iPadTeleport : MonoBehaviour
{
    private Vector3 startPos;
    private OVRGrabbable Grabbable;
    private Rigidbody RigidBody;
    public Transform Player;
    public bool onBelt;

    // Start is called before the first frame update
    void Start()
    {
        onBelt = true;
        startPos = transform.position;
        RigidBody = (Rigidbody)GetComponent("Rigidbody");
        Grabbable = (OVRGrabbable)GetComponent("OVRGrabbable");
        if (Player == null)
        {
            Player = transform.parent;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Grabbable.isGrabbed)
        {
            OVRGrabber grabber = Grabbable.grabbedBy;
            onBelt = false;
            transform.parent = null;
            //transform.SetParent(grabber.gameObject.transform);
            //transform.position = new Vector3(-0.0920000002f, 0.0260000676f, 0.0199999809f);
            //grabber.
            //print(grabber.name);
        }
        else if (!onBelt)
        {
            RigidBody.useGravity = true;
            RigidBody.isKinematic = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Trigger_Plane")
        {
            transform.parent = Player;
            transform.position = startPos;
            RigidBody.useGravity = false;
            RigidBody.isKinematic = true;
            transform.parent = Player;
            onBelt = true;
        }
        //print(other.name);
        
    }
}
