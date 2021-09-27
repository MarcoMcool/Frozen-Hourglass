using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    int currentNode;

    Vector3 endPos;
    float speed = 5f;

    public GameObject targetObject;
    public GameObject[] nodes;
    public SpawnCars spawnCars;
    int randomSpeed;
    // Start is called before the first frame update
    void Start()
    {
        spawnCars = FindObjectOfType<SpawnCars>();
        nodes = spawnCars.carNodes;
        endPos = nodes[currentNode].transform.position;
        randomSpeed = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
       
        float step = (speed + randomSpeed) * Time.deltaTime;
        if (Vector3.Distance(transform.position, endPos) > 1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPos, step);
        }
        else
        {
            if (Vector3.Distance(transform.position, endPos) < 1f && currentNode == 4)
            {
                Destroy(this.gameObject);
            }
            else
            {
                currentNode++;
                endPos = nodes[currentNode].transform.position;
            }
        }

    }
}
