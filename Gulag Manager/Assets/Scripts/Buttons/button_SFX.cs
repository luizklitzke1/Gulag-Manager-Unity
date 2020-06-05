using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class button_SFX : MonoBehaviour
{
   
    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    public void HoverSound()
    {
        myFx.PlayOneShot (hoverFx);
    }

    public void ClickSound()
    {
        myFx.PlayOneShot (clickFx);
    }

    void Update()
    {

        
    }


}
