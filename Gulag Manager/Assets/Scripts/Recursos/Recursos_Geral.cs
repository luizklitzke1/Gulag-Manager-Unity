using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;


public class Recursos_Geral : MonoBehaviour
{

    public ControladorGame controladorGame;

    public int carlos = 0;
    //Lista para as mensagens
    [SerializeField]
    List<Message> messageList = new List<Message>();

    public GameObject chatPanel, textObject;

    public int maxMessages = 9;

    public TextMeshProUGUI tipo_extract;

    //Imagens dos botões
    public Image img1;
    public Image img2;
    public float cooldown = 0.3F;
    bool isCooldown = false;

    public float risc;
    public float gasto;
    public float lucro;


    private Color32 vermelho;
    private Color32 verde;
    private Color32 branco;
    

    // Start is called before the first frame update
    void Start()
    {

        vermelho = new Color32(255,0,0,255);
        verde = new Color32(0,255,0,255);

        img1.fillAmount = 0;
        img2.fillAmount = 0;

    }

    // Update is called once per frame
    void Update()
    {

        
        if(Input.GetKeyDown(KeyCode.Space)){

            carlos ++; 
            SendMessage("Mensagem nova aki ó - " + carlos);
            
        }

        
        
        tipo_extract.SetText(ControladorGame.gulag_game.extracao_tipo);

        //Diminui o preenchimento durante o cooldown

        if (isCooldown)
        {

            img1.fillAmount -= 1 / cooldown * Time.deltaTime;
            img2.fillAmount -= 1 / cooldown * Time.deltaTime;

            if (img1.fillAmount <= 0)
            {
                img1.fillAmount = 0;
                img2.fillAmount = 0;
                isCooldown = false;
            }

        }

    }

     //Função chamada pelo botao de bater
    public void Hurt()
    {

        if (isCooldown == false)
        {

            lucro = 5*ControladorGame.gulag_game.populacao;
            risc = UnityEngine.Random.Range(0f, 1f);

            SendMessage(("Risco de Acidente: " + risc.ToString("0.00") + "/" + est_recur.Recursos.risc_injur + "."));
            


            if (risc <= est_recur.Recursos.risc_injur){
                
                SendMessage("Um trabalhador foi machucado!", "vermelho");

                ControladorGame.gulag_game.populacao--;
                ControladorGame.gulag_game.machucados ++;
                lucro = lucro/2;
                ControladorGame.gulag_game.dinheiro += lucro;
                Debug.Log("Aiai");
                
            }
            else{

                SendMessage("A trabalhar!", "verde");
                Debug.Log("A trabalhar");
                if(ControladorGame.gulag_game.machucados > 0){
                    lucro = lucro * ((ControladorGame.gulag_game.populacao - ControladorGame.gulag_game.machucados) / ControladorGame.gulag_game.populacao);
                    ControladorGame.gulag_game.dinheiro += lucro;

                }else{

                    ControladorGame.gulag_game.dinheiro += lucro;

                }

            }

            SendMessage(("Você faturou: " + lucro.ToString() + "."));
            isCooldown = true;
            img1.fillAmount = 1;
            img2.fillAmount = 1;
        }
        
    }


    //Função chamada pelo botao de ser legal
    public void Cool()
    {

        if (isCooldown == false)
        {
            gasto = UnityEngine.Random.Range(80f, 150f);

            if(ControladorGame.gulag_game.dinheiro >= gasto ){

                if(ControladorGame.gulag_game.machucados <= 0){

                    SendMessage(("Você não possui trabalhadores feridos!."));

                }else{
                
                    ControladorGame.gulag_game.machucados++;
                    ControladorGame.gulag_game.populacao++;

                    ControladorGame.gulag_game.dinheiro -= gasto;
                    SendMessage(("Um trabalhador está recebendo tratamento."));
                    SendMessage(("Você pagou: " + gasto ));
                    Debug.Log("Eae, meu consagrado!");
                    isCooldown = true;
                    img1.fillAmount = 1;
                    img2.fillAmount = 1;

                }
            }else{

                SendMessage(("Você não possui dinheiro para tratar um trabalhador."));
            }


        }
        
    }


    public void SendMessage(string _text, string _color = null){

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

        if (_color != null){

            switch (_color){
                case ("vermelho"):
                    newMessage.textObject.color = vermelho;
                    break;
                case ("verde"):
                    newMessage.textObject.color = verde;
                    break;
            }

            
        }
        

        messageList.Add(newMessage);

    }
}

[System.Serializable]
public class Message {

    public string text;

    public TextMeshProUGUI textObject;
}
