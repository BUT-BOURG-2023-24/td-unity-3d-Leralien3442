using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class MovePositionByAxis : MonoBehaviour
{

    public float speed = 10.0f;
    [SerializeField]
    private bool useRawAxis = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis;
        float yAxis;
        if (useRawAxis)
        {
            xAxis = Input.GetAxisRaw("Horizontal");
            yAxis = Input.GetAxisRaw("Vertical");
        }
        else
        {
            xAxis = Input.GetAxis("Horizontal");
            yAxis = Input.GetAxis("Vertical");
        }

        transform.position += new Vector3(xAxis * speed * Time.deltaTime, 0, yAxis * speed * Time.deltaTime);

    }
}
