using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gulag : MonoBehaviour {

    public string nome;
    public string nome_rus;
    public string descricao;

    public int r_detec;

    public int r_nevasca;
    public string clima;

    public int recursos;
    public string extracao_tipo;

    //Valores do campo
    public int felicidade;
    public int prod_mensal;
    public int medo;
    public int populacao;
    public int machucados;
    public float dinheiro;

    public static float capitalistas = 0.5f;
    public static float sovietes = 0.9f;

    public void SaveGulag(){
        SaveSystem.SaveGulag(this);
    }

    public void LoadGulag(){
        GulagData dataGulag = SaveSystem.LoadGulag();

        nome = dataGulag.gulag_gulag_nome;
        nome_rus = dataGulag.gulag_nome_rus;
        descricao = dataGulag.gulag_descricao;
        r_detec = dataGulag.gulag_r_detec;
        r_nevasca = dataGulag.gulag_r_nevasca;
        clima = dataGulag.gulag_clima;
        recursos = dataGulag.gulag_recursos;
        extracao_tipo = dataGulag.gulag_extracao_tipo;
        felicidade = dataGulag.gulag_felicidade;
        prod_mensal = dataGulag.gulag_prod_mensal;
        medo = dataGulag.gulag_medo;
        populacao = dataGulag.gulag_populacao;
        machucados = dataGulag.gulag_machucados;
        dinheiro = dataGulag.gulag_dinheiro;

    }
    

}