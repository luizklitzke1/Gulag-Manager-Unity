using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Get_Status_Medico : MonoBehaviour
{

    public est_med med;

    public TextMeshProUGUI nivel;
    public TextMeshProUGUI estado;

    public TextMeshProUGUI alocados;
    public TextMeshProUGUI leitos;
    public TextMeshProUGUI machucados;
    public TextMeshProUGUI chance_morte;
    public TextMeshProUGUI vel_atend;

    // Start is called before the first frame update
    void Start()
    {
       nivel.SetText(Convert.ToString(med.level));
       estado.SetText(Convert.ToString(med.estado));

       alocados.SetText(Convert.ToString(med.alocados));
       leitos.SetText(Convert.ToString(med.leitos));
       chance_morte.SetText(Convert.ToString(med.chance_morte));
       machucados.SetText(Convert.ToString(ControladorGame.gulag_game.machucados));


       vel_atend.SetText(Convert.ToString(med.vel_atend));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
