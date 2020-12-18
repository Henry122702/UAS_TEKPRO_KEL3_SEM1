using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerbar : MonoBehaviour
{

    Image timerBarTest;
    public float maxTime = 3f;
    float timeLeft;
    


    // Start is called before the first frame update
    void Start()
    {
      timerBarTest = GetComponent<Image> ();
      timeLeft = maxTime;  
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0) {
            timeLeft -= Time.deltaTime;
            timerBarTest.fillAmount = timeLeft / maxTime;
        } 

    }
}
