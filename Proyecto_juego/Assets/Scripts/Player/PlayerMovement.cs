using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public Sprite spriteUp;      
    public Sprite spriteDown;    
    public Sprite spriteLeft;    
    public Sprite spriteRight;   

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer; 
    private Vector2 movement;

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        
        if (movement.x > 0)
        {
            spriteRenderer.sprite = spriteRight; 
        }
        else if (movement.x < 0)
        {
            spriteRenderer.sprite = spriteLeft; 
        }
        else if (movement.y > 0)
        {
            spriteRenderer.sprite = spriteUp; 
        }
        else if (movement.y < 0)
        {
            spriteRenderer.sprite = spriteDown; 
        }
    }

    void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

