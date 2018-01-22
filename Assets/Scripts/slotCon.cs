using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class slotCon : MonoBehaviour, IDropHandler
{
    public GameObject item
    {
        get
        {
            if (transform.childCount>0)
            {
                return transform.GetChild (0).gameObject;
            }
            return null;
        }
    }

    #region idropHandler implementation

    public void OnDrop(PointerEventData eventData)
    {
        if (!item)
        {
            GameObject clone = Instantiate(Drager.item, Drager.item.transform.position, Quaternion.identity);
            clone.transform.SetParent(transform, true);
        }
    }
    #endregion
}
