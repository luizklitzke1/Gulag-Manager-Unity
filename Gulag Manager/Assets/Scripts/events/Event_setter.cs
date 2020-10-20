using UnityEngine.EventSystems;
using System.Collections;
using TMPro;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Event_setter : MonoBehaviour
{

    public Evento evento;

    //Imagem do template de evento
    public Image image;
    //Imagem do evento em si
    public Sprite img_event;

    public TextMeshProUGUI titulo;
    public TextMeshProUGUI desc;
    public TextMeshProUGUI btn1txt;
    public TextMeshProUGUI btn2txt;

    public GameObject btn1;
    public GameObject btn2;
    
    // Start is called before the first frame update
    void Start()
    {

        btn1.SetActive(true);
        btn2.SetActive(true);

        //Seta os textos do popup
        titulo.SetText(evento.titulo);
        desc.SetText(evento.desc);

        if (evento.txt_op1 != "ok"){
            btn1txt.SetText(evento.txt_op1);
            
        }
        else{
            btn1.SetActive(false);
        }
        
        btn2txt.SetText(evento.txt_op2);

        //Seta a img
        image.sprite = img_event;


    }
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
