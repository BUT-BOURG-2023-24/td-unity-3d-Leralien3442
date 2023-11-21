using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveByVelocity : MonoBehaviour
{
    public Rigidbody body = null;
    public float speed = 1.0f;
    public InputActionReference moveInputRef = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputMovement = moveInputRef.action.ReadValue<Vector2>();
        body.velocity = new Vector3(inputMovement.x * speed, body.velocity.y, inputMovement.y * speed);
    }
}
