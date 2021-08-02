using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIWorker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WorkerTimer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WorkerTimer()
    {
        yield return new WaitForSeconds(5f);
        print("waited");
        
    }
}
