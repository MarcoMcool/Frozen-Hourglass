using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LadderFall_controll : MonoBehaviour
{
    private PlayableDirector Director;
    public bool fall = false;
    // Start is called before the first frame update
    void Start()
    {
        Director = (PlayableDirector)GetComponent("PlayableDirector");
    }

    // Update is called once per frame
    void Update()
    {
        if (fall)
        {
            Director.Play();

        }
        else
        {
            Director.Pause();
        }
        
    }
}
