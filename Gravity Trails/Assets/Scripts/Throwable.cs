using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour
{
    public GameObject ObgectThrown;
    public int throwablecounter;
    public Vector3 offset;
    public Vector3 Direction;
    // Start is called before the first frame update
    void Start()
    {
        Direction = gameObject.("Player").GetComponent<Throwable>;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            offset = new Vector3(1, 0, 0);
            offset = transform.localScale.x * new Vector3(1, 0, 0);
            Vector3 throwablePosition = transform.position + offset;
            Instantiate(ObgectThrown, throwablePosition, transform.rotation);
            throwablecounter = +1;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
