using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class EstruturaData 
{
    public string est_nome;
    public int est_level;
    public int est_estado;
    public int est_alocados;

    public EstruturaData(Estrutura estrutura) {

        est_nome = estrutura.nome;
        est_level = estrutura.level;
        est_estado = estrutura.estado;
        est_alocados = estrutura.alocados;
    }

}
