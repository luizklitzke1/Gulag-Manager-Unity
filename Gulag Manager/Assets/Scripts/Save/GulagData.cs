using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GulagData 
{
    public string gulag_gulag_nome;
    public string gulag_nome_rus;
    public string gulag_descricao;
    
    public int gulag_r_detec;
    public int gulag_r_nevasca;
    public string gulag_clima;
    public int gulag_recursos;
    public string gulag_extracao_tipo;
    public int gulag_felicidade;
    public int gulag_prod_mensal;
    public int gulag_medo;
    public int gulag_populacao;
    public int gulag_machucados;
    public float gulag_dinheiro;
    public float gulag_capitalistas;
    public float gulag_sovietes;


    public GulagData (Gulag gulag) {

        gulag_gulag_nome = gulag.nome;
        gulag_nome_rus = gulag.nome_rus;
        gulag_descricao = gulag.descricao;
        gulag_r_detec = gulag.r_detec;
        gulag_r_nevasca = gulag.r_nevasca;
        gulag_clima = gulag.clima;
        gulag_recursos = gulag.recursos;
        gulag_extracao_tipo = gulag.extracao_tipo;
        gulag_felicidade = gulag.felicidade;
        gulag_prod_mensal = gulag.prod_mensal;
        gulag_medo = gulag.medo;
        gulag_populacao = gulag.populacao;
        gulag_machucados = gulag.machucados;
        gulag_dinheiro = gulag.dinheiro;

    }
    
}
