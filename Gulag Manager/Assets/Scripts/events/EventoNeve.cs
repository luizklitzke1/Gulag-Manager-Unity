using UnityEngine.EventSystems;
using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class EventoNeve : MonoBehaviour
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

        //pointerDown.callback.AddListener((e) => Debug.Log("CArlos"));
        pointerDown.callback.AddListener((e) => Neve());
        trigger.triggers.Add(pointerDown);

    }

    void Neve(){
        

        Debug.Log((obj.activeSelf));
        if (obj.activeSelf){
            Debug.Log("TA NEVANDO!"); 
            obj.SetActive(false);
            handler.DesativarEvento("EventoNeve");
        }
        else{
             Debug.Log("Não faz mais!");
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
