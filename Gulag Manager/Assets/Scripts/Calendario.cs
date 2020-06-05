
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Calendario : MonoBehaviour
{

    public TextMeshProUGUI txt_dia;
    public TextMeshProUGUI txt_mes_ano;
    public TextMeshProUGUI txt_vel;

    public int dia;
    private int dia_pos;
    public int semana;
    public int mes = 1;
    public int ano = 1918;

    private string[] meses = {"Janeiro","Fevereiro","Março","Abril","Maio","Junho",
                     "Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"};

    public float vel;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Contar_Dia());
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    IEnumerator Contar_Dia()
    {
        yield return new WaitForSeconds(vel);

                
        if (dia_pos == 6)
        {
            dia_pos = 0;
            semana ++;
        }
        else
        {
            dia_pos += 1;
        }
            

        if (dia == 28)
        {
            mes ++;
            dia = 1;
            semana = 0;

        }
        else
        {
            dia ++;
        }

        if (mes == 13)
        {
            ano ++;
            mes = 1;
        }

        txt_mes_ano.SetText(meses[mes] + " - " + Convert.ToString(ano));
        txt_dia.SetText("Dia - " + Convert.ToString(dia));
        txt_vel.SetText("Vel - " + Convert.ToString(vel) + "s / dia");
                
        StartCoroutine(Contar_Dia());

    }

}
