using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public Throwable direction;
    public float Speed = 8;
    public Vector3 offset;
    public Vector3 Direction;
    // Start is called before the first frame update
    void Start()
    {
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 1.99f);
        
        transform.position += direction.offset * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.CompareTag("Enemy"))
        {
            DestroyThrowable();  
        }
    }

    public void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}
