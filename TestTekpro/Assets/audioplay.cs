using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioplay : MonoBehaviour
{
    public AudioSource audiio2;
    public AudioClip plause;

    private void start()
    {
        audiio2.PlayOneShot (plause);
    }

}
