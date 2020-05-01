using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera rb;
    public Rigidbody ball; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, ball.position.z);
    }
}
