using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dejavu : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 50;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.W)  && rb.velocity.sqrMagnitude < 400)
        {
            moveForward();
        }
        if (Input.GetKey(KeyCode.A) && rb.angularVelocity.sqrMagnitude < 20)
        {
            turnLeft();
        }
        if (Input.GetKey(KeyCode.S) && rb.velocity.sqrMagnitude < 400)
        {
            moveBackward();
        }
        if (Input.GetKey(KeyCode.D) && rb.angularVelocity.sqrMagnitude < 20)
        {
            turnRight();
        }
    }

    public void moveForward()
    {
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);
    }

    public void moveBackward()
    {
        rb.AddRelativeForce(Vector3.back * speed, ForceMode.Force);
    }

    public void turnRight()
    {
        rb.AddRelativeTorque(0, 10, 0, ForceMode.Force);
    }

    public void turnLeft()
    {
        rb.AddRelativeTorque(0,-10, 0,ForceMode.Force);
        
    }
}
