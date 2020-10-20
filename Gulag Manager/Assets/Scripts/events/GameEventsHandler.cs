using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameEventsHandler : MonoBehaviour
{

    //Object do PopUp
    public GameObject popup;

    //Parte lógica do calendário
    public Calendario calend;

    //Game object da gameplay
    public GameObject gameplaymain;
    //public GameObject estrutuas;

    //Gulag atual
    private  Gulag gulag;

    System.Random random = new System.Random();

    //Lista com os game objects dos eventos
    public List<GameObject> eventos_objs;


    // Start is called before the first frame update
    void Start()
    {

        gulag = ControladorGame.gulag_game;

        //Escreve as funções nos gatilhos do calend
        calend.OnMudarDia += EventosDiarios;
        calend.OnMudarMes += EventosMensais;
        
    }

    //Ativar um evento e o popup
    public void AtivarEvento(string nome){
        GameObject temp = eventos_objs.Where(obj => obj.name == nome).SingleOrDefault();

        gameplaymain.SetActive(false);
        popup.SetActive(true);
        temp.SetActive(true);
    }

    //Desativar um evento e o popup
    public void DesativarEvento(string nome){
        GameObject temp = eventos_objs.Where(obj => obj.name == nome).SingleOrDefault();

        gameplaymain.SetActive(true);
        //estrutuas.SetActive(true);
        popup.SetActive(false);
        temp.SetActive(false);
    }

    //Eventos com chance diaria
    private void EventosDiarios(int dia, int dia_pos, int semana)
    {

        //Debug.Log("Mudou de dia! Dia: " + Convert.ToString(dia));
        
        //Probabilidade de nevasca (de 0-5)
        if (gulag.r_nevasca > 0){
            int prob_neve = random.Next(5);  
            Debug.Log(Convert.ToString(prob_neve)+ " - " + Convert.ToString(gulag.r_nevasca));
            if (prob_neve <= gulag.r_nevasca){

                AtivarEvento("EventoNeve"); 

            }
       
        }

        /*
        //Probabilidade de detecção (de 0-50)
        if (gulag.r_detec > 0){
            int prob_detec = random.Next(50);  
            Debug.Log(Convert.ToString(prob_detec)+ " - " + Convert.ToString(gulag.r_detec));
            if (prob_detec <= gulag.r_detec){
                Debug.Log("DETECTADO!");

                AtivarEvento("EventoDetec");         
                
            }
        }
        */


    }


    //Eventos com chance mensal
    private void EventosMensais(int mes)
    {
        //Debug.Log("Mudou de mes! Mes: " + Convert.ToString(mes));

        
    }
}
