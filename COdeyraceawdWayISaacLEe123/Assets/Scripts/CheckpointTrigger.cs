using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public bool didActivate;
    public CheckpointCount count;
    // Start is called before the first frame update
    void Start()
    {
        didActivate = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.tag == "Player" && didActivate == false)
        {
            didActivate = true;
            count.triggeredCheckponits++;
        }
    }
}
