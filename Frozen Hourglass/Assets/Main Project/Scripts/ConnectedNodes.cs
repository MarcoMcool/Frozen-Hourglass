using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectedNodes : MonoBehaviour
{
    public int index;
    public int[] linkedNodesIndex;
    public GameObject[] connectedNodes;
    // Start is called before the first frame update
    void Start()
    {
        //Get the correct index for each linked Node
        linkedNodesIndex = new int[connectedNodes.Length];

        for (int i = 0; i < linkedNodesIndex.Length; i++)
        {

            linkedNodesIndex[i] = connectedNodes[i].GetComponent<ConnectedNodes>().index;
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject linkedNode in connectedNodes)
        {
            Debug.DrawLine(transform.position, linkedNode.transform.position, Color.green);
        }
    }
}
