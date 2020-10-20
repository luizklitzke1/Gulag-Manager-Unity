using UnityEngine.EventSystems;
using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EventoTeste : MonoBehaviour
{

    public GameEventsHandler handler;

    public GameObject obj;
    public GameObject btn1;
    public GameObject btn2;

    // Start is called before the first frame update
    void Start()
    {

        EventTrigger trigger = btn2.AddComponent<EventTrigger>();
        var pointerDown = new EventTrigger.Entry();
        pointerDown.eventID = EventTriggerType.PointerDown;

        pointerDown.callback.AddListener((e) => Teste());
        trigger.triggers.Add(pointerDown);

    }

    void Teste(){
        

        if (obj.activeSelf){
            obj.SetActive(false);
            handler.DesativarEvento("EventoTeste");
        }
        else{
        }
        
       
    }


}
