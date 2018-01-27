using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMovment : MonoBehaviour {


    public float speed = 5f;


    private void Update()
    {
            transform.Translate(speed, 0, 0);
        

    }



}
