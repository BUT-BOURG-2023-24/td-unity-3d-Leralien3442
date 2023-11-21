using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public bool isOnGround = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void OnTriggerEnter(Collision collision)
    {
        UnityEngine.Debug.Log("Entered collision with " + collision.gameObject.name);
        isOnGround = true;
    }

    // Gets called when the object exits the collision
    void OnTriggerExit(Collision collision)
    {
        UnityEngine.Debug.Log("Exited collision with " + collision.gameObject.name);
        isOnGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
