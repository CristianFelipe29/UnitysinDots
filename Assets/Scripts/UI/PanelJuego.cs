using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PanelJuego : MonoBehaviour
{
    public TipoEjercito Ejercito1=null;
    public TipoEjercito Ejercito2=null;


    public TMP_Text CantidadText1;
    private int Cantidad1;

    public TMP_Text CantidadText2;
    private int Cantidad2;

    void Start(){
        Cantidad1 = Ejercito1.getCantidad();
        Cantidad2 = Ejercito2.getCantidad();

        UpdateCantidad();
    }


    void UpdateCantidad(){
        CantidadText1.text = Cantidad1.ToString();
        CantidadText2.text = Cantidad2.ToString();
    }



    
}
