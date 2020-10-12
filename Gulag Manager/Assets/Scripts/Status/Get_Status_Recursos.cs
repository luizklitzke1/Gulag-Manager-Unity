using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Get_Status_Recursos : MonoBehaviour
{

    public est_recur scr;

    public TextMeshProUGUI nivel;
    public TextMeshProUGUI estado;

    public TextMeshProUGUI alocados;
    public TextMeshProUGUI estoque;
    public TextMeshProUGUI vel;

    public TextMeshProUGUI ac1;
    public TextMeshProUGUI ac2;

    // Start is called before the first frame update
    void Start()
    {
       nivel.SetText(Convert.ToString(scr.level));
       estado.SetText(Convert.ToString(scr.estado));

       alocados.SetText(Convert.ToString(scr.alocados));
       estoque.SetText(Convert.ToString(scr.estoque));
       vel.SetText(Convert.ToString(scr.vel_estraxt));

       ac1.SetText(Convert.ToString(scr.total_injur));
       ac2.SetText(Convert.ToString(scr.risc_injur));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
