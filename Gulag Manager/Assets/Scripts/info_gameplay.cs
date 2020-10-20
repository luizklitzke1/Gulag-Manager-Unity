using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class info_gameplay : MonoBehaviour
{

    public TextMeshProUGUI nome_gulag;

    public TextMeshProUGUI hurt;
    public TextMeshProUGUI pop;
    public TextMeshProUGUI mon;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Controlador.gulag_atual.nome != null)
        {
            if (nome_gulag.text != Controlador.gulag_atual.nome)
            {
                Set_Data();
            }
            

        }
        */
        nome_gulag.SetText(Convert.ToString (ControladorGame.gulag_game.nome));
        hurt.SetText(Convert.ToString (ControladorGame.gulag_game.machucados));
        pop.SetText(Convert.ToString (ControladorGame.gulag_game.populacao));
        mon.SetText(Convert.ToString (ControladorGame.gulag_game.dinheiro));


    }

}