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

    //Gulag atual
    private Gulag gulag;

    public TextMeshProUGUI tipo_extract;

    // Start is called before the first frame update
    void Start()
    {

        gulag = ControladorGame.gulag_game;

        Debug.Log(gulag.extracao_tipo);
        
        tipo_extract.SetText(gulag.extracao_tipo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
