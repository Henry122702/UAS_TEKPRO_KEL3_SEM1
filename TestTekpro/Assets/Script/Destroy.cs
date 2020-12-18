using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Destroy : MonoBehaviour, IDropHandler 
{
    public PrefabSpawner itemCountRemoval;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            Destroy(eventData.pointerDrag);
            itemCountRemoval.itemCount--;
            Debug.Log("ItemCount Removed");
        }
    }
     

    
}