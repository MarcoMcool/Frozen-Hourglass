using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TutorialPoint: MonoBehaviour
{
    public GameObject rightHand;
    //public GameObject leftHand;
    private LineRenderer lineRenderer;
    public bool laserActive;
    public RaycastHit objectHit;

    public TutorialController tutController;
    public TextMeshProUGUI wallText;
    bool selected = false;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
    }

    void Update()
    {

        CreateLaser(rightHand.transform.position, rightHand.transform.forward, 10f);
        laserActive = true;
        lineRenderer.enabled = true;
    }

    void CreateLaser(Vector3 targetPos, Vector3 direction, float length)
    {
        Ray ray = new Ray(targetPos, direction);
        Vector3 endPos = targetPos + (direction * length);
        int layerMask = 1 << 8;
        layerMask = ~layerMask;
        if (Physics.Raycast(ray, out RaycastHit hit, length, layerMask))
        {
            endPos = hit.point;
            objectHit = hit;
            if (OVRInput.Get(OVRInput.RawButton.A))
            {
                checkObject();
            }
        }

        lineRenderer.SetPosition(0, targetPos);
        lineRenderer.SetPosition(1, endPos);
    }
    void checkObject()
    {
        if (objectHit.collider.name == "BlueCube" && !selected)
        {
            wallText.text = "Well Done. \n" +
                "Thats all for the tutorial. " +
                 "If you feel ready to progress select start.";
            tutController.NextTutorial();
            selected = true;
        }
    }
}
