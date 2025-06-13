using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyCollison : MonoBehaviour
{
    public GameObject Avatar;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }
        if (collision.gameObject.CompareTag("ThrowingObject"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("GroundShuriken"))
        {
            Destroy(gameObject);
        }
    }
}
