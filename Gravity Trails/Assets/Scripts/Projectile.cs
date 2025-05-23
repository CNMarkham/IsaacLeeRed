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
        transform.Rotate(0, 0, 1.9900000000000000000000000000000000000000000000000000000000000000000000000000000000999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999f);
        
        transform.position += direction.offset * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            DestroyThrowable();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}
