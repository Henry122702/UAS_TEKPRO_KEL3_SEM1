using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatienceMeter : MonoBehaviour
{
    public int maxpatience = 100;
    public float currenntmood;

    public Patience patience1;

    void Start()
    {
        currenntmood = maxpatience;
        patience1.SetMaxPatience(maxpatience);
    }

    void Update ()
    {
        timetimer();
    }
    void timetimer()
    {
        currenntmood -= Time.deltaTime;
        patience1.SetPatience(currenntmood);
    }
}
