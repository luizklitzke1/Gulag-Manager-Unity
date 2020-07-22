using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calend_visual : MonoBehaviour
{

    public Calendario calend;
     
    // Start is called before the first frame update
    void Start()
    {

        calend.OnMudarDia +=  MudarDiaVisual;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MudarDiaVisual(int dia, int dia_pos)
    {
        Debug.Log("Dia: " + dia + " -   Dia_pos: " + dia_pos);
    }
}
