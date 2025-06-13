using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class SoccerBall : MonoBehaviour
{
    public int goalNet2 = 0;
    public int goalNet1 = 0;

    public GameObject P1;
    public GameObject P2;   

    public Rigidbody2D rb;
    private Vector3 startPos;
    private Vector3 startPosP1;
    private Vector3 startPosP2;

    public TMP_Text scoreText;
    //public Transform ogPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startPosP1 = P1.transform.position;
        startPosP2 = P2.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var P1Score = goalNet1;
        var P2Score = goalNet2;

        scoreText.text = ($"P1 Score:{P1Score}/9 P2 Score:{P2Score}/2");

        if(goalNet1 == 9)
        {
            SceneManager.LoadScene(3);
        }

        if (goalNet2 == 2)
        {
            SceneManager.LoadScene(1);
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.gameObject.CompareTag("GoalNet1"))
        {
            goalNet1 += 1;
            RestartPoint();
        }

        if (collison.gameObject.CompareTag("GoalNet2"))
        {
            goalNet2 += 1;
            RestartPoint();
        }
    }

    public void RestartPoint()
    {
        transform.position = startPos;
        rb.velocity = new Vector3(0, 0, 0);
        P1.transform.position = startPosP1;
        P2.transform.position = startPosP2;
    }
}
