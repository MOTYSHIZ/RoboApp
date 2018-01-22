using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InForward : MonoBehaviour {

    
    public GameObject forward;
    //public GameObject backwards;
    //public GameObject right;
    //public GameObject left;

    GameObject Forwardclone;
    //GameObject Backwardsclone;
    //GameObject Rightclone;
    //GameObject Leftclone;

  

    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            Forwardclone = Instantiate(forward, transform.position, Quaternion.identity) as GameObject;
            //Backwardsclone = Instantiate(backwards, transform.position, Quaternion.identity) as GameObject;
            //Rightclone = Instantiate(right, transform.position, Quaternion.identity) as GameObject;
            //Leftclone = Instantiate(left, transform.position, Quaternion.identity) as GameObject;
        }
    }
}
