using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Teleport1 : MonoBehaviour
{
    public int enemyCount1;
    void Update()
    {
        enemyCount1 = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && enemyCount1 == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
