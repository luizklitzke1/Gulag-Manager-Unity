using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_gameplay : MonoBehaviour
{

    public Gulag gulag;

    // Start is called before the first frame update
    void Start()
    {

        if (Controlador.gulag_atual == null)
        {
            ControladorGame.gulag_game = gulag;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
