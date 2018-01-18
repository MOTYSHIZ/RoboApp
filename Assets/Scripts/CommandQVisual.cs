using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandQVisual : MonoBehaviour {

    public List<GameObject> commandIcons;

	// Use this for initialization
	void Start () {
	}

    // Update is called once per frame
    public void addIconVisual (int type) {
        GameObject icon = Instantiate(commandIcons[type]);
        
        icon.transform.SetParent(gameObject.transform, false);
        //icon.transform.localScale = new Vector3(1, 1, 1);
    }

    public void removeFirstIconVisual()
    {
        Destroy(gameObject.transform.GetChild(0).gameObject);
    }
}
