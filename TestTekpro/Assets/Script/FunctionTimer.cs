using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTimer 
{

    

    public static FunctionTimer Create(Action action, float timer){
       
        GameObject gameObject = new GameObject("FunctionTimer", typeof(MonoBehaviourHook));
       
        FunctionTimer functionTimer = new FunctionTimer(action, timer, gameObject);
       
        gameObject.GetComponent<MonoBehaviourHook>().onUpdate = functionTimer.Update;

        return functionTimer;
        
    }


    // Dummy Class biar bisa akses fungsi MonoBehaviour
    public class MonoBehaviourHook : MonoBehaviour {
        public Action onUpdate;
        private void Update(){
            if (onUpdate != null) onUpdate();
        }
    }

    private Action action;
    private float timer;
    private bool isDestroyed;
    private GameObject gameObject;

    private FunctionTimer(Action action, float timer, GameObject gameObject){
        this.action = action;
        this.timer = timer;
        this.gameObject = gameObject;
        isDestroyed = false;
    }

    
    public void Update()
    {
        if(!isDestroyed) {
        timer -= Time.deltaTime;
        if (timer < 0 ){
            action();
            DestroySelf();
           }    
        }
    }
    
    private void DestroySelf(){
            isDestroyed = true;
            UnityEngine.Object.Destroy(gameObject);
        }
} 

