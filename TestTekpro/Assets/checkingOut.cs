using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class checkingOut : MonoBehaviour, IDropHandler 
{
    
    public ItemDrop checkOutStageSetFinal;
    public ItemDrop checkOutStageSetFinal2;
    public GameObject progressBar2;
    public Transform BarLocation;
    private GameObject target;
    private CanvasGroup customerg;
    private int patience;
    public int itemCount;

    public PrefabSpawner itemCountRemoval;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            Debug.Log ("Working");
            if (eventData.pointerDrag.GetComponent<DragDrop>().state == 2){
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().state = 3;
                eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = false;
                Instantiate(progressBar2, BarLocation.position, transform.rotation, GameObject.FindGameObjectWithTag("Bar2").transform);
                FunctionTimer.Create(TestingAction, 5f);
                patience = (int)eventData.pointerDrag.GetComponent<PatienceMeter>().currenntmood ;
                eventData.pointerDrag.GetComponent<CanvasGroup>().blocksRaycasts = true;
                target = eventData.pointerDrag;

            }        
        
        }
     
    }  

    public void TestingAction()
    {
        GameControl.moneyAmount += 50 + patience;
        Destroy(target);
        itemCount --;
    }
}
