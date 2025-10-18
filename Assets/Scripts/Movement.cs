using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumpSpeed = 3;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

 
    void FixedUpdate()
    {
        if(Input.GetKey("d")){
            rb.velocity = new Vector2(runSpeed, rb.velocity.y);
        }
        else if(Input.GetKey("a")){
            rb.velocity = new Vector2(-runSpeed, rb.velocity.y);
        }
        else {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if(Input.GetKey("space") && GroundCheck.isGrounded){
            rb.velocity = new Vector2(rb.velocity.x,jumpSpeed);
        }
    }
}
