using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDrop : MonoBehaviour, IDropHandler 
{

    public GameObject[] healthbars;
    public GameObject progressBar;
    public Transform BarLocation;
    private CanvasGroup customerg;
    private int status = 1;
    //public int checkOutStageSet = 1;


    void Start()
    {}

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (status == 1){
            Debug.Log("working");
            if (eventData.pointerDrag != null) {
                if (eventData.pointerDrag.GetComponent<DragDrop>().state == 1){
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<DragDrop>().state = 2;
                    Debug.Log(eventData.pointerDrag.GetComponent<DragDrop>().state);
                    eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = false;
                    customerg = eventData.pointerDrag.GetComponent<CanvasGroup>();
                    //checkOutStageSet = 2;
                    Instantiate(progressBar, BarLocation.position, transform.rotation, GameObject.FindGameObjectWithTag("Bar2").transform);
                    status = 2;
                    FunctionTimer.Create(TestingAction, 10f);
                    status = 1;
                }
            }
            
            
        }
    }
          
    private void TestingAction(){
        //checkOutStageSet = 3;
        Debug.Log("Test");
        Debug.Log("times up");
        customerg.blocksRaycasts = true;
        customerg = null;
            
        
    }

   
    
}
