using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelSelect1 : MonoBehaviour
{

    public void Anterior_1(){
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void Romano_1(){
        SceneManager.LoadScene("PantallaRomano");
    }

    public void Alien_1(){
        SceneManager.LoadScene("PantallaAlien");
    }

    public void Logo_1(){
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void Salir_1(){
        Application.Quit();
    }
}
