using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Calendario : MonoBehaviour
{
    public bool firstTime = true;
    public event OnMudarDiaDelegate OnMudarDia;
    public delegate void OnMudarDiaDelegate(int dia, int dia_pos, int semana);

    public event EventHandler OnMudarMes;

    public TextMeshProUGUI txt_vel;

    /*public class OnMudarDiaArgs: EventArgs
    {
        public int dia;
        public int dia_pos;
    }*/

    public int dia = 1;
    public int dia_pos = 0;

    public int semana = 1;

    public int mes = 1;
    public int ano = 1918;

    public List<string> meses = new List<string>() {
        "Janeiro",
        "Fevereiro",
        "Março",
        "Abril",
        "Maio",
        "Junho",
        "Julho",
        "Agosto",
        "Setembro",
        "Outubro",
        "Novembro",
        "Dezembro"
    };

    public List<int> meses_qtdias = new List<int>() { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    public float vel_base;
    public float vel;

    public float internalVel = 0;

    // Start is called before the first frame update
    void Start()
    {

        OnMudarMes?.Invoke(this, EventArgs.Empty);
        OnMudarDia?.Invoke(dia, dia_pos, semana);

        StartCoroutine("Contar_Dia");

        //IEnumerator coroInstance = Contar_Dia ();
        //while (coroInstance.MoveNext ()) {

        //}
    }
    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Contar_Dia()
    {
        if (firstTime == false)
        {
            Debug.Log("Pai lembro que marcha é coisa de viado");
            internalVel = vel;
        }
        else
        {
            Debug.Log("Pai ta engatado na primeira");
            firstTime = false;
        }

        yield return new WaitForSeconds(internalVel);
        if (vel != 0)
        {
            if (dia == (meses_qtdias[mes - 1] + 1))
            {
                mes++;
                dia = 1;
                semana = 1;
                OnMudarMes?.Invoke(this, EventArgs.Empty);
                OnMudarDia?.Invoke(dia, dia_pos, semana);
                dia++;
            }
            else
            {
                OnMudarDia?.Invoke(dia, dia_pos, semana);
                Debug.Log(Time.time.ToString("F2"));

                dia++;
            }

            if (dia_pos == 6)
            {
                dia_pos = 0;
                semana++;
            }
            else
            {
                dia_pos++;
            }

            if (mes == 13)
            {
                ano++;
                mes = 1;
            }

            ControladorGame.gulag_game.machucados += 1;
            ControladorGame.gulag_game.populacao += 1;
            ControladorGame.gulag_game.dinheiro += 11.23f;

        }
        else
        {
            txt_vel.SetText("Vel - Pausado");
        }
        StartCoroutine(Contar_Dia());
    }
}