using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelSelect2 : MonoBehaviour
{
    public TipoEjercito romano2;
    public TipoEjercito alien2;
    public TipoEjercito ejercito2;

    public void Anterior_4(){
        SceneManager.LoadScene("PantallaSelect");
    }

    public void Romano_1(){
        SceneManager.LoadScene("PantallaRomano2");
        ejercito2.setEjercito("ROMANO");
        ejercito2.setDescripcion(romano2.getDescripcion());
        ejercito2.setModelo(romano2.getModelo());
    }

    public void Alien_1(){
        SceneManager.LoadScene("PantallaAlien2");
        ejercito2.setEjercito("ALIEN");
        ejercito2.setDescripcion(alien2.getDescripcion()); 
        ejercito2.setModelo(alien2.getModelo());
    }

    public void Logo_4(){
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void Salir_4(){
        Application.Quit();
    }
}
