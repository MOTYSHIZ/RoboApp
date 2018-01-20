using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drager : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public static GameObject itemDrag;
    Vector3 startp;    Transform startPar;


    public void OnBeginDrag(PointerEventData eventData)
    {
        itemDrag = gameObject;
        startp = transform.position;
        startPar = transform.parent;
        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        itemDrag = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent != startPar)
        {
            transform.position = startp;
        }
    }
}
