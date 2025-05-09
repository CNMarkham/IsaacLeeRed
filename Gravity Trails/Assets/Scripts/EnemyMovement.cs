using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.right * speed, ForceMode2D.Impulse);
    }

    public void Update()
    {
        transform.Rotate(0, 0, 1.99f);
    }

    // Update is called once per frame
    private void fixedUpdate()
    {
        transform.Rotate(0, 0, 1.99f);  
        //        Vector2 newDirection = PlayerTransform.localScale;
        //        Vector2 newDirection2 = EnemyTransform.localScale;
        //        if (maximumXPosition < newDirection.x)
        //       {
        //            newDirection2.x = +1;
        //        }
        if (transform.position.x <= -8 || transform.position.x >= 8)
    {
        speed *= -1;
    }
    float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
    float newYPosition = transform.position.y;
    Vector2 newPosition = new Vector2(newXPosition, newYPosition);
    transform.position = newPosition;
    }
}