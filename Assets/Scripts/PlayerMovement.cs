﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    Rigidbody rb;
    public float moveSpeed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveForward();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            turnLeft();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveBackward();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            turnRight();
        }
    }

    void moveForward()
    {
        transform.Translate(Vector3.forward);
    }

    void moveBackward()
    {
        transform.Translate(Vector3.back);
    }

    void turnRight()
    {
        transform.Rotate(Vector3.up, 90);
    }

    void turnLeft()
    {
        transform.Rotate(Vector3.up, -90);
    }
}
