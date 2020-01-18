using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    CharacterController cC;

    public float speed;
    public float jumpSpeed;
    public float midairSpeed;
    public float gravity;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cC = GetComponent<CharacterController>();

        //transform.position = new Vector3(-3.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        if (Input.GetKey(left))
        {
            rb.velocity = new Vector3(-speed, 0.0f, 0.0f);
            Debug.Log("Player is moving left");
            //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        } else if (Input.GetKey(right))
        {
            rb.velocity = new Vector3(speed, 0.0f, 0.0f);
            Debug.Log("Player is moving right");
        } else
        {
            rb.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        }

        if (cC.isGrounded)
        {
            //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
            //moveDirection *= speed;
            if (Input.GetKey(jump))
            {
                Debug.Log("Player has JUMPED!");
                //moveDirection.y = jumpSpeed;
                rb.velocity = new Vector3(0.0f, jumpSpeed, 0.0f);
            }
        }

        //moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        //cC.Move(moveDirection * Time.deltaTime);
        //rb.MovePosition(transform.position + transform.right * Time.fixedDeltaTime);
    }

}

