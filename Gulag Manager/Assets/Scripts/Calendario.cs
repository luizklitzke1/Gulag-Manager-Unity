using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calendario : MonoBehaviour
{

    public GameObject gameplaymain;
    public bool firstTime = true;
    public event OnMudarDiaDelegate OnMudarDia;
    public delegate void OnMudarDiaDelegate(int dia, int dia_pos, int semana);

    public delegate void OnMudarMesDelegate(int mes);
    public event OnMudarMesDelegate OnMudarMes;

    public TextMeshProUGUI txt_vel;

    public float risc;
    public float rendaFixa;

    /*public class OnMudarDiaArgs: EventArgs
    {
        public int dia;
        public int dia_pos;
    }*/

    public int dia = 1;
    public int dia_pos = 0;

    public int semana = 1;

    public int mes = 1;
    public int ano = 1918;

    public List<string> meses = new List<string>() {
        "Janeiro",
        "Fevereiro",
        "Março",
        "Abril",
        "Maio",
        "Junho",
        "Julho",
        "Agosto",
        "Setembro",
        "Outubro",
        "Novembro",
        "Dezembro"
    };

    public List<int> meses_qtdias = new List<int>() { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public float vel_base;
    public float vel;

    public float internalVel = 0;

    // Start is called before the first frame update
    void Start()
    {

        OnMudarMes?.Invoke(mes);
        OnMudarDia?.Invoke(dia, dia_pos, semana);

        StartCoroutine("Contar_Dia");

        //IEnumerator coroInstance = Contar_Dia ();
        //while (coroInstance.MoveNext ()) {

        //}
    }
    // Update is called once per frame
    void Update()
    {
        rendaFixa = ControladorGame.gulag_game.populacao;
    }

    IEnumerator Contar_Dia()
    {
        if (firstTime == false)
        {
            internalVel = vel;
        }
        else
        {
            firstTime = false;
        }


        yield return new WaitForSeconds(internalVel);
        if (vel != 0 && gameplaymain.activeSelf)
        {
            if (dia == (meses_qtdias[mes - 1] + 1))
            {
                mes++;
                dia = 1;
                semana = 1;
                OnMudarMes?.Invoke(mes);
                OnMudarDia?.Invoke(dia, dia_pos, semana);
                dia++;
            }
            else
            {
                OnMudarDia?.Invoke(dia, dia_pos, semana);

                dia++;
                ControladorGame.gulag_game.dinheiro += rendaFixa;
            }

            if (dia_pos == 6)
            {
                dia_pos = 0;
                semana++;
                risc = UnityEngine.Random.Range(0f, 1f);
                ControladorGame.gulag_game.populacao ++;
                if(risc <= est_recur.Recursos.risc_injur){
                    ControladorGame.gulag_game.machucados ++;
                    ControladorGame.gulag_game.populacao --;
                }
            }
            else
            {
                dia_pos++;
            }

            if (mes == 13)
            {
                ano++;
                mes = 1;
            }

            

        }
        else
        {
            txt_vel.SetText("Vel - Pausado");
        }
        StartCoroutine(Contar_Dia());
    }
}