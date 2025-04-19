using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;
    public Transform avatarTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (avatarRigidbody.gravityScale == 1f)
            {
                avatarRigidbody.gravityScale = -1f;
                Vector2 newDirection = avatarTransform.localScale;
                newDirection.y *= -1f;
            }
            else
            {
                avatarRigidbody.gravityScale = 1f;
                Vector2 newDirection = avatarTransform.localScale;
                newDirection.y *= 1f;
            }
        }
    }
}
