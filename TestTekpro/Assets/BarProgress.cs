using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarProgress : MonoBehaviour
{
    public Slider slider;

    public void SetTime()
    { 
        slider.value -= Time.deltaTime;
    }

    public void SlideDestroy()
    {
        if(slider.value == 0f){
            Destroy(gameObject);
        }
      
    }

    void Update ()
    {
        SetTime();
        SlideDestroy();
    }
    
}

