using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact_recursos : MonoBehaviour
{

    public Image img1;
    public Image img2;

    public float cooldown = 5;
    bool isCooldown = false;

    // Start is called before the first frame update
    void Start()
    {

        img1.fillAmount = 0;
        img2.fillAmount = 0;

    }

    // Update is called once per frame
    void Update()
    {

        //Diminui o preenchimento durante o cooldown
        if (isCooldown)
        {

            //img1.fillAmount -= 1 / cooldown * Time.deltaTime;
            //img2.fillAmount -= 1 / cooldown * Time.deltaTime;

            if (img1.fillAmount <= 0)
            {
                img1.fillAmount = 0;
                img2.fillAmount = 0;
                isCooldown = false;
            }

        }

    }

    //Função chamada pelo botao de bater
    public void Hurt()
    {

        if (isCooldown == false)
        {

            Debug.Log("Aiai");
            isCooldown = true;
            img1.fillAmount = 1;
            img2.fillAmount = 1;
        }
        
    }


    //Função chamada pelo botao de ser legal
    public void Cool()
    {

        if (isCooldown == false)
        {

            Debug.Log("Eae, meu consagrado!");
            isCooldown = true;
            img1.fillAmount = 1;
            img2.fillAmount = 1;
        }
        
    }
}
