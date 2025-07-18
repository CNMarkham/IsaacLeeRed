using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("obstacles"))
        {
            other.gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
