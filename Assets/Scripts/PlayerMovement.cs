using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    
    public float groundDrag;

    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;
    
    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start(){
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    // Update is called once per frame
    private void Update(){
        //Ground Check
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight*0.5f+0.2f,whatIsGround);
        
        //Get Inputs
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        //Handle Drag
        if (grounded){
            rb.linearDamping = groundDrag;
        }else{
            rb.linearDamping = 0;
        }
    }
    private void FixedUpdate(){
        //Calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }    
}
