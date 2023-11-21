using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class JumpBehaviour : MonoBehaviour
{
    public InputActionReference jumpActionRef = null;
    public Rigidbody body = null;
    public float jumpPower = 250.0f;
    private bool isOnGround = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnEnable()
    {
        jumpActionRef.action.performed += OnJumpInputPressed;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnDisable()
    {
        jumpActionRef.action.performed -= OnJumpInputPressed;
    }

        private void OnJumpInputPressed(InputAction.CallbackContext context)
    {
        Jump();
    }

    private void Jump()
    {

        if (isOnGround)
        {
            body.AddForce(Vector3.up * jumpPower);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        UnityEngine.Debug.Log("Entered collision with " + collision.gameObject.name);
        isOnGround = true;
    }

    // Gets called when the object exits the collision
    void OnCollisionExit(Collision collision)
    {
        UnityEngine.Debug.Log("Exited collision with " + collision.gameObject.name);
        isOnGround = false;
    }
}
