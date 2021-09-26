using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCars : MonoBehaviour
{
    float randomTime;
    public GameObject carSpawn;
    public GameObject carSpawnLocation;
    public GameObject[] carNodes;
    float currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(currentTime + "current time" + randomTime);
        currentTime += Time.deltaTime;
        if (currentTime >= randomTime)
        {
            randomTime = Random.Range(3, 5);
            currentTime = 0;
            Instantiate(carSpawn, carSpawnLocation.transform.position, Quaternion.identity);
        }
    }
}
