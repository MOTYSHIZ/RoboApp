using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject target;
    private Vector3 point;

    // Use this for initialization
    void Start()
    {
        point = target.transform.position;
        transform.LookAt(point);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(point);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(RotateMe(1, 0.8f));
            //CamRotateAround(1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(RotateMe(-1, 0.8f));
            //CamRotateAround(-1);
        }
    }


    IEnumerator RotateMe(int direction, float inTime)
    {
        //Left
        if (direction == 1)
        {
            for (var t = 0f; t < 1; t += Time.deltaTime / inTime)
            {
                Debug.Log(t);
                transform.RotateAround(point, Vector3.up, t);
                yield return null;
            }
        }
        //Right
        else if (direction == -1) {
            for (var t = 0f; t > -1; t -= Time.deltaTime / inTime)
            {
                Debug.Log(t);
                transform.RotateAround(point, Vector3.up, t);
                yield return null;
            }
        }
    }


    //Old code
    // Rotate camera
    public void CamRotateAround(int direction)
    {
        //Rotate Left
        if (direction == 1)
        {
            transform.RotateAround(point, Vector3.up, 90);
        }
        //Rotate Right
        else if (direction == -1)
        {
            transform.RotateAround(point, Vector3.up, -90);
        }
    }

}