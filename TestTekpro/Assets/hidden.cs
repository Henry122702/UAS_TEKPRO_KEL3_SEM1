using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidden : MonoBehaviour
{
    public GameObject ts;
    public GameObject tc;

    public void Start()
    {
        Debug.Log ("check image5");
        if (ts.activeInHierarchy == true)
        {
            tc.SetActive(true);
        }
    }
}

