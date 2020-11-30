using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class calend_visual : MonoBehaviour
{

    public Calendario calend;

    public TextMeshProUGUI txt_dia;
    public TextMeshProUGUI txt_mes_ano;
    public TextMeshProUGUI txt_vel;

    public List<TextMeshProUGUI> lista_dias;

    // Start is called before the first frame update
    void Start()
    {

        txt_mes_ano.SetText(calend.meses[calend.mes - 1] + " " + Convert.ToString(calend.ano));
        txt_dia.SetText("Dia - " + Convert.ToString(calend.dia));
        txt_vel.SetText("Vel - " + Convert.ToString(calend.vel) + "s / dia");

        calend.OnMudarDia += MudarDiaVisual;
        calend.OnMudarMes += MudarMesVisual;

    }

    // Update is called once per frame
    void Update()

    {

        txt_vel.SetText("Vel - " + Convert.ToString(calend.vel) + "s / dia");

    }


    private void MudarMesVisual(int mes)
    {

        txt_mes_ano.SetText(calend.meses[calend.mes - 1] + " " + Convert.ToString(calend.ano));

        foreach (TextMeshProUGUI dia in lista_dias)
        {
            dia.SetText(" ");
        }

    }
    private void MudarDiaVisual(int dia, int dia_pos, int semana)
    {
        txt_dia.SetText("Dia - " + Convert.ToString(dia));

        if (dia != 1)
        {
            lista_dias[(semana - 1) * 7 + dia_pos].SetText("0");
            lista_dias[(semana - 1) * 7 + dia_pos - 1].SetText("X");

        }
        else if (dia_pos == 0)
        {
            lista_dias[0].SetText("0");
        }
        else if (dia_pos != 0 && dia == 1)
        {
            lista_dias[(semana - 1) * 7 + dia_pos].SetText("0");
            lista_dias[(semana - 1) * 7 + dia_pos - 1].SetText("");
        }

        else
        {
            lista_dias[(semana - 1) * 7 + dia_pos].SetText("0");

        }

    }
}
