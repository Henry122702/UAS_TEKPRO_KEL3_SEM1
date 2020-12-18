using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    Text text;
    float day;
    public float speed = 1;
    
     // Start is called before the first frame update
    void Start() {
        text = GetComponent<Text>();     
    }

    // Update is called once per frame
    void Update() {
        
        float dayNormalized = day % 1f;
        float hoursPerDay = 17f;
        float minutesPerHour = 60f;
        
        day += Time.deltaTime * speed;
        string hourString = Mathf.Floor(dayNormalized * hoursPerDay).ToString("00");
        string minuteString = Mathf.Floor((dayNormalized * hoursPerDay) % 1f * minutesPerHour).ToString("00");
        text.text = hourString + ":" + minuteString;
    
       
    }
}
