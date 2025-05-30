using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    int goalNet1 = 0;
    int goalNet2 = 0;
    private Vector3 StartPos;
    //public Transform ogPos;

    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("GoalNet1"))
        {
            goalNet1 += 1;
            RestartPoint();
        }

        if (gameObject.CompareTag("GoalNet2"))
        {
            goalNet2 += 1;
            RestartPoint();
        }
    }

    private void RestartPoint()
    {
        transform.position = StartPos; 
    }
}
