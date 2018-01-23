using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject item;
    //public GameObject forward;

    //GameObject Forwardclone;
    Transform startParent;
    Vector3 startp;
    bool start = true;


   



    public void OnBeginDrag(PointerEventData eventData)
    {
        item = gameObject;

        //Reset Draggable to initial position
        startp = transform.position;
        startParent = transform.parent;


        GetComponent<CanvasGroup>().blocksRaycasts = false;
        item.GetComponent<LayoutElement>().ignoreLayout = true;
        item.transform.SetParent(item.transform.parent.parent);


    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (transform.parent == startParent.parent)
        {

            transform.position = startp;
            transform.SetParent(startParent.transform,true);
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        item.GetComponent<LayoutElement>().ignoreLayout = false;
        item = null;
    }
}
