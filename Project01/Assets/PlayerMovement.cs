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

    //private Vector3 moveDirection = Vector3.zero;

    public bool isGrounded = false;


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

        if (Input.GetKeyDown(jump) && isGrounded)
        {
            Debug.Log("Player has JUMPED!");
            //moveDirection.y = jumpSpeed;
            rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, 0.0f);
            isGrounded = false;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Path"))
        {
            isGrounded = true;
            Debug.Log("Player is touching Path");
        }
    }

}

