using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CodeyMove : MonoBehaviour
{
    public float Speed = 15f;
    Animator anim;
    public bool running = false;
    public bool canMove = true;
    public Vector3 move;
    public float _rotationSpeed = 50f;
    public Rigidbody rb;
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;
    }
    void Update()
    {
       
        if (canMove)
        {

            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");            
            Vector3 rotation = new Vector3(0, horizontal * _rotationSpeed * Time.deltaTime, 0);
            move = transform.forward * Speed * Time.deltaTime * vertical;
            transform.Rotate(rotation);
            rb.AddForce(move, ForceMode.VelocityChange);

            anim.SetBool("isRunning", move != Vector3.zero);
        }
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Terrain")
        {
            SceneManager.LoadScene(0);
        }
    }
}