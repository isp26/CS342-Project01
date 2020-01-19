using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float speed;
    public float jumpForce;
    public float travelSpeed;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2.5f;


    //Key bindings can be set individually.
    public KeyCode left;            //'A' for P1. 'Left Arrow' for P2.
    public KeyCode right;           //'W' for P1. 'Right Arrow' for P2.
    public KeyCode jump;            //'D' for P1. 'Up Arrow' for P2.

    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Moves player forward continuously
        //transform.position += Vector3.forward * Time.deltaTime * travelSpeed;
        //rb.AddForce(0.0f, 0.0f, 9000f * Time.deltaTime);

        //Basic left and right movement.
        if (Input.GetKey(left))
        {
            rb.velocity = new Vector3(-speed, rb.velocity.y, 0.0f);
            //Debug.Log("Player is moving left");
        } else if (Input.GetKey(right))
        {
            rb.velocity = new Vector3(speed, rb.velocity.y, 0.0f);
            //Debug.Log("Player is moving right");
        } else
        {
            rb.velocity = new Vector3(0.0f, rb.velocity.y, 0.0f);
        }

        //Checks isGrounded status and if the jump key is pressed. Jumps.
        if (Input.GetKeyDown(jump) && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0.0f);
            //rb.velocity = Vector3.up * jumpSpeed;

            isGrounded = false;
            //Debug.Log("Player has JUMPED!");
        } 

        //if player is falling, this controls how fast they fall
        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && !Input.GetKey(jump))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    //isGrounded conditional statement
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Path"))
        {
            isGrounded = true;
            Debug.Log("Player is touching Path");
        }
    }

}

