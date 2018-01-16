using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject target;
    private Vector3 point;

	// Use this for initialization
	void Start ()
    {
        point = target.transform.position;
        transform.LookAt(point);
	}

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(point);
        if (Input.GetKeyDown(KeyCode.Q))
        {
            CamRotateAround(1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            CamRotateAround(-1);
        }
    }

    // Rotate camera
    public void CamRotateAround(int direction)
    {
        if (direction == 1)
        {
            transform.RotateAround(point, Vector3.up, 90);
        }
        else if (direction == -1)
        {
            transform.RotateAround(point, Vector3.up, -90);
        }
    }

}
