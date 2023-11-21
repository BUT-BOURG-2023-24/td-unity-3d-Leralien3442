using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MovePositionByKeys : MonoBehaviour
{

    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputMovment = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            inputMovment.z += 1f * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            inputMovment.z += -1f * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            inputMovment.z += 1f * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            inputMovment.z += -1f * speed * Time.deltaTime;
        }
        transform.position += inputMovment;
    }
}
