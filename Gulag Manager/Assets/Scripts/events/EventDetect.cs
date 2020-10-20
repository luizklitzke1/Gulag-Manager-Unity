using UnityEngine.EventSystems;
using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EventDetect : MonoBehaviour
{

    public GameEventsHandler handler;

    public GameObject obj;
    public GameObject btn1;
    public GameObject btn2;

    // Start is called before the first frame update
    void Start()
    {
        
        EventTrigger trigger = btn1.AddComponent<EventTrigger>();
        var pointerDown = new EventTrigger.Entry();
        pointerDown.eventID = EventTriggerType.PointerDown;

        pointerDown.callback.AddListener((e) => Carlos());
        trigger.triggers.Add(pointerDown);

        //////////////////////////////////////////////////////////////////

        EventTrigger trigger2 = btn2.AddComponent<EventTrigger>();
        var pointerDown2 = new EventTrigger.Entry();
        pointerDown2.eventID = EventTriggerType.PointerDown;

        pointerDown2.callback.AddListener((e) => Carlos2());
        trigger2.triggers.Add(pointerDown2);

    }

    void Carlos(){
        

        if (obj.activeSelf){
            obj.SetActive(false);
            handler.DesativarEvento("EventoDetec");
        }
        else{

        }
        
       
    }

     void Carlos2(){
        
        if (obj.activeSelf){
            obj.SetActive(false);
            handler.DesativarEvento("EventoDetec");
        }
        else{

        }
        
       
    }


}
