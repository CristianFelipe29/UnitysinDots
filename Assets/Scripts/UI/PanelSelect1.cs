using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelSelect1 : MonoBehaviour
{
    public TipoEjercito romano;
    public TipoEjercito alien;
    public TipoEjercito ejercito1;

    public void Anterior_1(){
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void Romano_1(){
        SceneManager.LoadScene("PantallaRomano");
        ejercito1.setEjercito("ROMANO");
        ejercito1.setDescripcion(romano.getDescripcion());
        ejercito1.setModelo(romano.getModelo());
    }

    public void Alien_1(){
        SceneManager.LoadScene("PantallaAlien");
        ejercito1.setEjercito("ALIEN");
        ejercito1.setDescripcion(alien.getDescripcion()); 
        ejercito1.setModelo(alien.getModelo());

    }

    public void Logo_1(){
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void Salir_1(){
        Application.Quit();
    }
}
