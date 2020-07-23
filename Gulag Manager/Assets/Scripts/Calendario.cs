
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Calendario : MonoBehaviour
{

    public event OnMudarDiaDelegate OnMudarDia;
    public delegate void OnMudarDiaDelegate(int dia, int dia_pos, int semana);

    public event EventHandler OnMudarMes;

    public TextMeshProUGUI txt_vel;

    /*public class OnMudarDiaArgs: EventArgs
    {
        public int dia;
        public int dia_pos;
    }*/

    public int dia = 1;
    public int dia_pos;

    private int carlos;

    public int semana = 1;

    public int mes = 1;
    public int ano = 1918;

    public List<string> meses = new List<string>() {"Janeiro","Fevereiro","Março","Abril","Maio","Junho",
                     "Julho","Agosto","Setembro","Outubro","Novembro","Dezembro"};
    
    public List<int> meses_qtdias =new List<int>() {31,28,31,30,31,30,31,31,30,31,30,31};

    public float vel_base;
    public float vel;

    // Start is called before the first frame update
    void Start()
    {

        OnMudarMes?.Invoke(this, EventArgs.Empty);
        OnMudarDia?.Invoke(dia,dia_pos,semana);
        
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


            if (dia == (meses_qtdias[mes-1]+1))
            {
                mes ++;
                dia = 1;
                semana = 1;
                OnMudarMes?.Invoke(this, EventArgs.Empty);
                OnMudarDia?.Invoke(dia,dia_pos,semana);
            }
            else
            {
                OnMudarDia?.Invoke(dia,dia_pos,semana);
                dia ++;
            }

            if (dia_pos == 6)
            {
                dia_pos = 0;
                semana ++;
            }
            else
            {
                dia_pos ++;
            }

            if (mes == 13)
            {
                ano ++;
                mes = 1;
            }
            

            ControladorGame.gulag_game.machucados += 1;
            ControladorGame.gulag_game.populacao += 1;
            ControladorGame.gulag_game.dinheiro += 11.23f;
            

            StartCoroutine(Contar_Dia());

        }
        else{
            carlos ++;
            txt_vel.SetText("Vel - Pausado" + carlos);
        }

        

    }

}
