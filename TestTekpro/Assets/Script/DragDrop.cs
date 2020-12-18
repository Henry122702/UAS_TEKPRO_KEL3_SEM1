using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas rootCanvas;
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public int state;
    public int state2;
    public int centerCardNum; // specified in Unity
 
    void Awake() {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        state = 1;
 
     
    }
 
    public void OnBeginDrag(PointerEventData eventData) {
        
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.6f;
        state2 = state;
    }
 
    public void OnDrag(PointerEventData eventData) {
        rectTransform.anchoredPosition += eventData.delta;
    }
 
    public void OnEndDrag(PointerEventData eventData) {
        if (state == state2){
            Debug.Log("OnEndDrag");
            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1f;
            state2 = state;
        }
        Debug.Log("OnEndDrag");
        canvasGroup.alpha = 1f;
       
        // GetComponent<Transform>().SetParent(GameObject.Find("CenterCardsCanvas").GetComponent<Transform>());
        // GetComponent<Transform>().SetSiblingIndex(0);
        // GetComponent<RectTransform>().SetParent(GameObject.Find("CenterCardsCanvas").GetComponent<RectTransform>());
        // GetComponent<RectTransform>().SetSiblingIndex(0);
 
        
 
    }
 
    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("OnPointerDown");
    }
}