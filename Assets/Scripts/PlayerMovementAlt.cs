using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementAlt : MonoBehaviour
{
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //moveForward();
            StartCoroutine(Move(0.8f));
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

    IEnumerator Move(float inTime)
    {
        var fromPosition = transform.position;
        //var toPosition = Quaternion.Euler(transform.eulerAngles + positions);
        var toPosition = transform.position - Vector3.forward;
        for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
        {
            transform.position = Vector3.Slerp(fromPosition, toPosition, t);
            yield return null;
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
