using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventsHandler : MonoBehaviour
{

    public Calendario calend;

    

    // Start is called before the first frame update
    void Start()
    {

        //Escreve as funções nos gatilhos do calend
        calend.OnMudarDia += EventosDiarios;
        calend.OnMudarMes += EventosMensais;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Eventos com chance diaria
    private void EventosDiarios(int dia, int dia_pos, int semana)
    {

        Debug.Log("Mudou de dia! Dia: " + Convert.ToString(dia));

    }


    //Eventos com chance mensal
    private void EventosMensais(int mes)
    {

        Debug.Log("Mudou de mes! Mes: " + Convert.ToString(mes));

    }
}
