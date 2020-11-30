using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fill_Bars : Gulag
{
    public Image bar_sov;
    public Image bar_cap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bar_sov.fillAmount = Gulag.sovietes;
        bar_cap.fillAmount = Gulag.capitalistas;
    }

}
