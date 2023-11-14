using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PanelRomano : MonoBehaviour
{
    public TipoEjercito Romano1=null;
    public TipoEjercito Alien1=null;
    public TMP_InputField inCantidad;
    public TMP_InputField inVida;
    public TMP_InputField inFuerza;
    public TMP_InputField inVelocidad;
    
    private int cantidadRomano1;
    private int vidaRomano1;
    private int fuerzaRomano1;
    private int velocidadRomano1;


    public void inputCantidad(){
        cantidadRomano1 = Convert.ToInt32(inCantidad.text);
        Romano1.setCantidad(cantidadRomano1);
    }
    
    public void inputVida(){
        vidaRomano1 = Convert.ToInt32(inVida.text);
        Romano1.setVida(vidaRomano1);
    }

    public void inputFuerza(){
        fuerzaRomano1 = Convert.ToInt32(inFuerza.text);
        Romano1.setFuerza(fuerzaRomano1);
    }

    public void inputVelocidad(){
        velocidadRomano1 = Convert.ToInt32(inVelocidad.text);
        Romano1.setVelocidad(velocidadRomano1);
    }
    

    public void Siguiente_2(){
         if(Romano1.getCantidad() != 0 && Alien1.getCantidad() != 0){
            SceneManager.LoadScene("PantallaCarga");
        }else if(Romano1.getCantidad() == 0 || Alien1.getCantidad() == 0){
            SceneManager.LoadScene("PantallaSelect2");
        }
    }   

    public void Anterior_2(){
        SceneManager.LoadScene("PantallaSelect");
    }

    public void Logo_2(){
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void Salir_2(){
        Application.Quit();
    }
}
