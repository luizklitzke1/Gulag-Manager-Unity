using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enviar_gulag : MonoBehaviour
{
    
    public void achar_gulag (string nome)
    {
        GameObject gulag = GameObject.Find(nome);

        
        Gulag gulag_script = gulag.GetComponent<Gulag>();


        Controlador.gulag_atual = gulag_script;

    }

}
