using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpShadow : MonoBehaviour {
    //Rigidbody rb;

    private Vector3 startPos;
    private Vector3 endPos;
    private float lerp = 0;
    private float duration = 1.5f;

    private float time = 0.1f;
    

    // Use this for initialization
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        startPos = transform.position;
        //endPos = GameObject.Find("Invisible Marker").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //endPos = GameObject.Find("Invisible Marker").transform.position;
        //lerp += Time.deltaTime / duration;
        
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

    public void moveForward()
    {
        transform.Translate(Vector3.forward);
        transform.position = Vector3.Lerp(startPos, endPos, time * Time.deltaTime);
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
