using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class est_med : Estrutura
{

    public float chance_morte = 00f;
    public float r;
    public int leitos = 5;
    public int vel_atend;
    public static est_med Medico;

    // Start is called before the first frame update
    void Start()
    {

        GameObject Estrutura_Medico = GameObject.Find("Medico");

        est_med script_med = Estrutura_Medico.GetComponent<est_med>();

        Medico = script_med;


        StartCoroutine(Heal());


    }


    // Update is called once per frame
    void Update()
    {
        if(ControladorGame.gulag_game.machucados < 0){
            
            ControladorGame.gulag_game.machucados = 0;
        }

        if(ControladorGame.gulag_game.machucados > leitos){

            ControladorGame.gulag_game.machucados--;
            
        }

        if (Medico.level == 2)
        {
            animator.SetInteger("medicoLvl", 2);
        }
    }

    IEnumerator Heal(){

        yield return new WaitForSeconds(vel_atend);

        if (ControladorGame.gulag_game.machucados > 0){

            r = UnityEngine.Random.Range(0f, 1f);

            if(r<= chance_morte ){
                ControladorGame.gulag_game.machucados--;
            }else{
                
                ControladorGame.gulag_game.machucados--;
                ControladorGame.gulag_game.populacao++;
                
            }
            

        }
        StartCoroutine(Heal());
    }
}
