using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIsnishLine : MonoBehaviour
{
    public CheckpointCount checkponitTracker;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if(checkponitTracker.triggeredCheckponits == checkponitTracker.numberOfCheckpoints)
            {
                Debug.Log("Yaya you winwam yay :)");
            }
            if (checkponitTracker.triggeredCheckponits != checkponitTracker.numberOfCheckpoints)
            {
                Debug.Log("Nice Job You did it the wrong way");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
