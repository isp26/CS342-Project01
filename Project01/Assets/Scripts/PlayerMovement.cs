using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float centerPos;
    public float centerHeight;
    public float flowHeight;
    //public float speed;
    public float forwardSpeed;


    //Key bindings can be set individually.
    public KeyCode left;            //'A' for P1. 'Left Arrow' for P2.
    public KeyCode right;           //'W' for P1. 'Right Arrow' for P2.
    public KeyCode up;            //'D' for P1. 'Up Arrow' for P2.
    public KeyCode down;

    private bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    int nowPos = 0;
    int nowHeight = 0;

    private void FixedUpdate()
    {
        Movement();
    }

    void Update()
    {
        GetInput();


        //Moves player forward continuously
        //transform.position += Vector3.forward * Time.deltaTime * travelSpeed;
        //rb.AddForce(0.0f, 0.0f, 9000f * Time.deltaTime);

        //Basic left and right movement.
        

        //if player is falling, this controls how fast they fall
        /*if(rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0 && !Input.GetKey(jump))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }*/
    }

    void GetInput()
    {
        
        if (Input.GetKeyDown(left))
        {
            nowPos -= 1;
            if (nowPos < -1)
                nowPos = -1;
            //rb.velocity = new Vector3(-speed, rb.velocity.y, 0.0f);
            //Debug.Log("Player is moving left");
        }
        if (Input.GetKeyDown(right))
        {
            nowPos += 1;
            if (nowPos > 1)
                nowPos = 1;
            //rb.velocity = new Vector3(speed, rb.velocity.y, 0.0f);
            //Debug.Log("Player is moving right");
        }


        //Checks isGrounded status and if the jump key is pressed. Jumps.
        if (Input.GetKeyDown(up))
        {
            nowHeight += 1;
            if (nowHeight > 1)
                nowHeight = 1;
            //jumpPressed = true;
            //isGrounded = false;
            //rb.velocity = Vector3.up * jumpSpeed;

            //isGrounded = false;
            //Debug.Log("Player has JUMPED!");
        }
        if (Input.GetKeyDown(down))
        {
            nowHeight -= 1;
            if (nowHeight < 0)
                nowHeight = 0;
        }
    }

    void Movement()
    {
        Vector3 nextPos = rb.position;
        nextPos.x = centerPos + nowPos;
        nextPos.y = centerHeight + nowHeight * flowHeight;
        nextPos.z += forwardSpeed * Time.deltaTime;
        rb.MovePosition(nextPos);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.collider.tag == "Obj")
    }

    //isGrounded conditional statement
    /*void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Path"))
        {
            isGrounded = true;
            Debug.Log("Player is touching Path");
        }
    }*/
}

