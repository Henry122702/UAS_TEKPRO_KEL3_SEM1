using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    public Text moneyText;
    public static int moneyAmount;
    public GameObject demoScreen;
    public GameObject gameplay;
    public GameObject dragAndDrop;
 
  


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("MoneyAmount", 0);
        moneyAmount = PlayerPrefs.GetInt ("MoneyAmount");
        FunctionTimer.Create(TestingAction, 40f);
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = moneyAmount.ToString() + "$";
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);

    }

    private void TestingAction()
    {
      demoScreen.SetActive(true);
      gameplay.SetActive(false);
      dragAndDrop.SetActive(false);

        
    }
}
