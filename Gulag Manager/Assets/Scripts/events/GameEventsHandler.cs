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
    private Gulag gulag;

    System.Random random = new System.Random();

    //Lista com os game objects dos eventos
    public List<GameObject> eventos_objs;

    //Lista que serve como fila para os eventos
    public List<GameObject> fila_eventos;

    //Som do alerta
    public AudioSource myFx;
    public AudioClip alertFx;

    // Start is called before the first frame update
    void Start()
    {

        gulag = ControladorGame.gulag_game;

        //Escreve as funções nos gatilhos do calend
        calend.OnMudarDia += EventosDiarios;
        calend.OnMudarMes += EventosMensais;
        
    }

    void Update(){
        
        if (fila_eventos.Count()>0 && !(fila_eventos[0].activeSelf)){
            //Debug.Log(fila_eventos[0].name);
            AtivarEvento(fila_eventos[0].name);
        }
       

    }

    //Adicionar eventos para a lista de execução
    public void AdicionarEvento(string nome){
         GameObject temp = eventos_objs.Where(obj => obj.name == nome).SingleOrDefault();
         fila_eventos.Add(temp);

    }

    //Ativar um evento e o popup
    public void AtivarEvento(string nome){

        GameObject temp = eventos_objs.Where(obj => obj.name == nome).SingleOrDefault();

        myFx.PlayOneShot (alertFx);
        gameplaymain.SetActive(false);
        popup.SetActive(true);
        temp.SetActive(true);

    }

    //Desativar um evento e o popup
    public void DesativarEvento(string nome){

        GameObject temp = eventos_objs.Where(obj => obj.name == nome).SingleOrDefault();
        fila_eventos.Remove(temp);

        gameplaymain.SetActive(true);
        //estrutuas.SetActive(true);
        temp.SetActive(false);
        popup.SetActive(false);

        
    }

    //Eventos com chance diaria
    private void EventosDiarios(int dia, int dia_pos, int semana)
    {
        AdicionarEvento("Eventocarlos");  
        

    }


    //Eventos com chance mensal
    private void EventosMensais(int mes)
    {

        //Debug.Log("Mudou de dia! Dia: " + Convert.ToString(dia));
        

        //Probabilidade de detecção (de 0-50)
        if (gulag.r_detec > 0){
            int prob_detec = random.Next(50);  
            //Debug.Log(Convert.ToString(prob_detec)+ " - " + Convert.ToString(gulag.r_detec));
            if (prob_detec <= gulag.r_detec){
                Debug.Log("DETECTADO!");

                AdicionarEvento("EventoDetec");         
                
            }
        }

        //Probabilidade de nevasca (de 0-5)
        if (gulag.r_nevasca > 0){
            int prob_neve = random.Next(5);  
            //Debug.Log(Convert.ToString(prob_neve)+ " - " + Convert.ToString(gulag.r_nevasca));
            if (prob_neve <= gulag.r_nevasca){

                AdicionarEvento("EventoNeve"); 
                AdicionarEvento("EventoTeste"); 

            }
       
        }
        
        //Debug.Log("Mudou de mes! Mes: " + Convert.ToString(mes));

        
    }
}
