using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu_inicial : MonoBehaviour
{
    public void PlayGame () {

        SceneManager.LoadScene ("Menus-Selecao");
    }

    public void QuitGame () {

        Application.Quit();
        Debug.Log("Quit");
    }
}
