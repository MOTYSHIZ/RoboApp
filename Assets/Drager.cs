using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public static GameObject item;

    Transform startParent;
    Vector3 startp;
    bool start = true;
    //sprite sprite


    public void OnBeginDrag(PointerEventData eventData)
    {
        item = gameObject;
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
        item = null;
        //transform.position = startp;
        if (transform.parent== startParent)
        {
            transform.position = startp;
        }
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        item.GetComponent<LayoutElement>().ignoreLayout = false;
    }
}
