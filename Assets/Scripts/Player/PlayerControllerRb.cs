using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRb : MonoBehaviour
{
    Rigidbody2D rb;

    public float walkSpeed = 4f;
    public float speedLimiter = 0.7f;
    public float horizontalInput;
    public float verticalInput;



    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        
    }

    private void FixedUpdate()
    {
        if(horizontalInput != 0 || verticalInput != 0)
        {
            if(horizontalInput != 0 && verticalInput != 0)
            {
                horizontalInput *= speedLimiter;
                verticalInput *= speedLimiter;
            }

            rb.velocity = new Vector2(horizontalInput * walkSpeed, verticalInput * walkSpeed);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
    }
}
