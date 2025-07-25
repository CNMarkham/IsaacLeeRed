using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallPhaser : MonoBehaviour
{
    public GameObject[] Secreatewall;

    // Start is called before the first frame update
    public void Start()
    {
        Secreatewall = GameObject.FindGameObjectsWithTag("SecreatePlace");
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 25;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("SecreatePlace"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
