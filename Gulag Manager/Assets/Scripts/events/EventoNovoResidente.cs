using UnityEngine.EventSystems;
using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EventoNovoResidente : MonoBehaviour
{

    public GameEventsHandler handler;
    public float risc;
    public GameObject obj;
    public GameObject btn1;
    public GameObject btn2;

    // Start is called before the first frame update
    void Start()
    {

        EventTrigger trigger = btn2.AddComponent<EventTrigger>();
        var pointerDown = new EventTrigger.Entry();
        pointerDown.eventID = EventTriggerType.PointerDown;

        pointerDown.callback.AddListener((e) => NovoResidente());
        trigger.triggers.Add(pointerDown);

    }

    void NovoResidente(){
        

        if (obj.activeSelf){

            risc = UnityEngine.Random.Range(0f, 1f);
            ControladorGame.gulag_game.populacao ++;
            if(risc <= est_recur.Recursos.risc_injur){
                ControladorGame.gulag_game.machucados ++;
                ControladorGame.gulag_game.populacao --;
            }
            obj.SetActive(false);
            handler.DesativarEvento("EventoNovoResidente");
        }
    }


}
