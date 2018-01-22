using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InBack : MonoBehaviour
{

    public GameObject backwards;
    //public GameObject right;
    //public GameObject left;

    GameObject Backwardsclone;
    //GameObject Rightclone;
    //GameObject Leftclone;



    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {

            Backwardsclone = Instantiate(backwards, transform.position, Quaternion.identity) as GameObject;

        }

    }
}
