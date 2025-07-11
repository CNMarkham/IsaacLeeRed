using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCount : MonoBehaviour
{
    public int numberOfCheckpoints;
    public int triggeredCheckponits;
    // Start is called before the first frame update
    void Start()
    {
        numberOfCheckpoints = GameObject.FindGameObjectsWithTag("checkpoint").Length;
    }

    // Update is called once per frame
    void Update()
    {
        numberOfCheckpoints = GameObject.FindGameObjectsWithTag("checkpoint").Length;
    }
}
