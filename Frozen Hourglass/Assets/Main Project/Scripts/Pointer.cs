using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer: MonoBehaviour
{
    public GameController gameController;
    public GameObject rightHand;
    public GameObject leftHand;
    private LineRenderer lineRenderer;
    public bool laserActive;
    public RaycastHit objectHit;

    public PointHazards PointHazards;
    
    // Start is called before the first frame update
    void Start()
    {
        PointHazards.GetComponent<PointHazards>();
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((OVRInput.Get(OVRInput.RawButton.RHandTrigger) && OVRInput.Get(OVRInput.RawButton.A)) ||Input.GetKey(KeyCode.U))
        {
            CreateLaser(rightHand.transform.position, rightHand.transform.forward, 10f);
            laserActive = true;
            lineRenderer.enabled = true;
        }
        else if ((OVRInput.Get(OVRInput.RawButton.LHandTrigger) && OVRInput.Get(OVRInput.RawButton.X)) || Input.GetKey(KeyCode.I))
        {
            CreateLaser(leftHand.transform.position, leftHand.transform.forward, 10f);
            laserActive = true;
            lineRenderer.enabled = true;
        }
        else
        {
            laserActive = false;
            lineRenderer.enabled = false;
        }
    }


    void CreateLaser(Vector3 targetPos, Vector3 direction, float length)
    {
        Ray ray = new Ray(targetPos, direction);
        Vector3 endPos = targetPos + (direction * length);
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        if (Physics.Raycast(ray, out RaycastHit hit, length,layerMask))
        {
            endPos = hit.point;
            objectHit = hit;
            checkObject();
            print(hit.collider.gameObject.name);
        }

        lineRenderer.SetPosition(0, targetPos);
        lineRenderer.SetPosition(1, endPos);
    }

    void checkObject()
    {
        if (objectHit.collider.GetComponent<Hazard>())
        {
            print("object has hazard script");
            GameObject hazardObject;
            hazardObject = objectHit.collider.gameObject;
            if (PointHazards.objectsFound.Contains(hazardObject))
            {
                print("object in objects found");
                return;
            }
            else
            {
                print("hazard not in objects found");
                PointHazards.objectsFound.Add(hazardObject);
            }
        }
    }


}
