using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMessShell : MonoBehaviour
{
    public GameObject[] obstacles;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    private void Start()
    {
        obstacles = GameObject.FindGameObjectsWithTag("obstacles");
        agent = GetComponent<NavMeshAgent>();
        agent.destination = obstacles[0].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("obstacles"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
