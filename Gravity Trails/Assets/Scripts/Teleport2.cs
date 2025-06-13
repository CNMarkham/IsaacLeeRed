using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Teleport2 : MonoBehaviour
{
    public int enemyCount2;
    void Update()
    {
        enemyCount2 = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && enemyCount2 == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
