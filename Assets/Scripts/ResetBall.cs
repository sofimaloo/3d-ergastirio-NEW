using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ResetBall : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    public void ResetBallPosition()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = initialPosition;
        transform.rotation = initialRotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBallPosition();
        }
    }
}
