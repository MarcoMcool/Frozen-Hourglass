using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer: MonoBehaviour
{
    public GameObject rightHand;
    public GameObject leftHand;
    private LineRenderer lineRenderer;

    
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.02f;
        lineRenderer.endWidth = 0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger) && OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            CreateLaser(rightHand.transform.position, rightHand.transform.forward, 10f);

            lineRenderer.enabled = true;
        }
        else if (OVRInput.Get(OVRInput.RawButton.LHandTrigger) && OVRInput.Get(OVRInput.RawButton.LIndexTrigger))
        {
            CreateLaser(leftHand.transform.position, leftHand.transform.forward, 10f);

            lineRenderer.enabled = true;
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }


    void CreateLaser(Vector3 targetPos, Vector3 direction, float length)
    {
        Ray ray = new Ray(targetPos, direction);
        Vector3 endPos = targetPos + (direction * length);
        int layerMask = 1 << 2;
        layerMask = ~layerMask;
        if (Physics.Raycast(ray, out RaycastHit hit, length,layerMask))
        {
            endPos = hit.point;
            print(hit.collider.gameObject.name);
        }

        lineRenderer.SetPosition(0, targetPos);
        lineRenderer.SetPosition(1, endPos);
    }
}
