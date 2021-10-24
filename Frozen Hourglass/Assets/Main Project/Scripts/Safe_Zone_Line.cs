using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe_Zone_Line : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject safe_zone;
    void Start()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(1, safe_zone.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, transform.parent.position);
        //lineRenderer.SetPosition(1, safe_zone.transform.position);
    }
}
