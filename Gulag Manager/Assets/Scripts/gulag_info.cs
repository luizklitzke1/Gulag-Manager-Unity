using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gulag_info : MonoBehaviour
{

    public TextMeshProUGUI nome_gulag;
    public TextMeshProUGUI nome_rus;
    public TextMeshProUGUI descricao;
    public TextMeshProUGUI deteccao;
    public TextMeshProUGUI nevasca;
    public TextMeshProUGUI recursos;
    public TextMeshProUGUI extracao;
    public TextMeshProUGUI clima;
    

    void Set_Data()
    {

        nome_gulag.SetText(Controlador.gulag_atual.nome);
        nome_rus.SetText(Controlador.gulag_atual.nome_rus);
        descricao.SetText(Controlador.gulag_atual.descricao);

        deteccao.SetText(Convert.ToString(Controlador.gulag_atual.r_detec+ "-50"));

        recursos.SetText(Convert.ToString(Controlador.gulag_atual.recursos)+ "-10");
        extracao.SetText(Controlador.gulag_atual.extracao_tipo);

        if (Controlador.gulag_atual.extracao_tipo == "Mineração")
        {
            extracao.color = new Color32(122, 122, 122, 255);
        } 
        else
        {
            extracao.color = new Color32(0, 255, 0, 255);
        }

        nevasca.SetText(Convert.ToString(Controlador.gulag_atual.r_nevasca + "-5"));
        clima.SetText(Controlador.gulag_atual.clima);
        clima.color = new Color32(0, 0, 255, 255);
        

    }

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Controlador.gulag_atual.nome != null)
        {
            if (nome_gulag.text != Controlador.gulag_atual.nome)
            {
                Set_Data();
            }

        }
        
       
    }
    
}

