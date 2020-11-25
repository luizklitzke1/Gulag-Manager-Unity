using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Linq;
using TMPro;


public class Recursos_Geral : MonoBehaviour
{


    public int carlos = 0;
    //Lista para as mensagens
    [SerializeField]
    List<Message> messageList = new List<Message>();

    public GameObject chatPanel, textObject;

    public int maxMessages = 9;

    //Gulag atual
    private Gulag gulag;

    public TextMeshProUGUI tipo_extract;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space)){

            carlos ++; 
            SendMessage("Mensagem nova aki ó - " + carlos);
        }

        gulag = ControladorGame.gulag_game;
        
        tipo_extract.SetText(gulag.extracao_tipo);

    }


    public void SendMessage(string _text){

        /*
        if(messageList.Count >= maxMessages){

            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }
        */

        Message newMessage = new Message();
        newMessage.text = _text;

        GameObject newText = Instantiate(textObject, chatPanel.transform);

        newMessage.textObject = newText.GetComponent<TextMeshProUGUI>();

        newMessage.textObject.text = newMessage.text;

        messageList.Add(newMessage);

    }
}

[System.Serializable]
public class Message {

    public string text;

    public TextMeshProUGUI textObject;
}
