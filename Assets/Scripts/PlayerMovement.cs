using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float moveSpeed = 1.0f;

    public Transform start;
    public Transform end;
    private float startTime;
    private float journeyLength;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        journeyLength = Vector3.Distance(start.position, end.position);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveForward();
            //float distCovered = (Time.time - startTime) * moveSpeed;
            //float fracJourney = distCovered / journeyLength;
            //transform.position = Vector3.Lerp(start.position, end.position, fracJourney);
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

    public void moveForward()
    {
        transform.Translate(Vector3.forward);

    }

    public void moveBackward()
    {
        transform.Translate(Vector3.back);
    }

    public void turnRight()
    {
        transform.Rotate(Vector3.up, 90);
    }

    public void turnLeft()
    {
        transform.Rotate(Vector3.up, -90);
    }
}
