using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    public Animator animator;
    private SpriteRenderer sprite;

    float horizontal;
    float vertical;
    float moveLimiter = 0.7f;

    public float runSpeed = 20.0f;

    void Start ()
    {
        sprite = GetComponent<SpriteRenderer>();
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
        vertical = Input.GetAxisRaw("Vertical"); // -1 is down
    }

    void FixedUpdate()
    {
        if (horizontal != 0 || vertical != 0) // Check for diagonal movement
        {
            if (horizontal < 0)
            {
                sprite.flipX = true;
                
            }
            else if (horizontal > 0)
            {
                sprite.flipX = false;
            }
            
            animator.SetFloat("Speed", Mathf.Abs(horizontal) + Mathf.Abs(vertical));
            
            // limit movement speed diagonally, so you move at 70% speed
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }

        
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}