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
        transform.Rotate(0, 0, 1.99f);
        if (Input.GetButtonDown("Jump"))
        {
            if (avatarRigidbody.gravityScale == 1f)
            {
                avatarRigidbody.gravityScale = -1f;
                Vector2 newDirection = avatarTransform.localScale;
                newDirection = avatarTransform.localScale;
                newDirection.y = -1;
                avatarTransform.localScale = newDirection*1;
            }
            else
            {
                avatarRigidbody.gravityScale = 1f;
                Vector2 newDirection = avatarTransform.localScale;
                newDirection = avatarTransform.localScale;
                newDirection.y = 1;
                avatarTransform.localScale = newDirection*1;
            }
        }
    }
}
