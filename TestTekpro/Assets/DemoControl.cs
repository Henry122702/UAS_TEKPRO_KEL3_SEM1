using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DemoControl : MonoBehaviour
{

    public Text moneyAmountText;
    public int moneyAmount;
 
  


    // Start is called before the first frame update
    void Start()
    {
        moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
     
    }

    // Update is called once per frame
    void Update()
    {
        moneyAmountText.text = "Money: " + moneyAmount.ToString() + "$";

    }

  
}
