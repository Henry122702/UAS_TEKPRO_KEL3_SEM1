using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Patience : MonoBehaviour
{
    public Slider slider;

    public void SetMaxPatience(float patience)
    {
        slider.maxValue = patience;
        slider.value = patience;
    }

    public void SetPatience(float patience)
    {
        slider.value = patience;
    }
}
