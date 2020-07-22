
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

    public event OnMudarDiaDelegate OnMudarDia;
    public delegate void OnMudarDiaDelegate(int dia, int dia_pos);

    /*public class OnMudarDiaArgs: EventArgs
    {
        public int dia;
        public int dia_pos;
    }*/

    public int dia;
    private int dia_pos;
    public int semana;
    public int mes = 1;
    public int ano = 1918;

    private string[] meses = {"Janeiro","Fevereiro","Março","Abril","Maio","Junho",
                     "Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"};

    public float vel_base;
    public float vel;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("Contar_Dia");


    }

    // Update is called once per frame
    void Update()
    {

        if (vel == 0){
            StartCoroutine("Contar_Dia");
        }

    }

    IEnumerator Contar_Dia()
    {

        if (vel != 0)
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
                OnMudarDia?.Invoke(dia,dia_pos);
            }

            if (mes == 13)
            {
                ano ++;
                mes = 1;
            }

            txt_mes_ano.SetText(meses[mes] + " - " + Convert.ToString(ano));
            txt_dia.SetText("Dia - " + Convert.ToString(dia));
            txt_vel.SetText("Vel - " + Convert.ToString(vel) + "s / dia");

            ControladorGame.gulag_game.machucados += 1;
            ControladorGame.gulag_game.populacao += 1;
            ControladorGame.gulag_game.dinheiro += 11.23f;
            

            StartCoroutine(Contar_Dia());

        }
        else{
            txt_vel.SetText("Vel - Pausado");
        }

        

    }

}
