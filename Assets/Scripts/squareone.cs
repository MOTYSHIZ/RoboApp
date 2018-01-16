using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class squareone : MonoBehaviour {
    Vector3 pos;

	// Use this for initialization
	void Start () {
    }

    private void Update()
    {
        pos = transform.position;
        if (pos.y < -16) //The -16 can be any negative vale of your choice
        {
            //ResetPosition();
            //OR
            SceneManager.LoadScene(Application.loadedLevel);     /* the name of your scene between those double quotes*/
            //The above line will reload the level, so if you don't want that to happen, DO NOT use that method.
        }
    }

    //public void ResetPosition()
    //{
    //    transform.position = Vector3.zero; //Resets entire transform position, including X axis, Y axis, and Z axis
    //                                       //OR
    //    pos.y = 0.0f; //Resets Z axis only, so if you don't want the other axis to reset, use this
    //}

   
}
