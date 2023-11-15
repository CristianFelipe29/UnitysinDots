using UnityEngine;
using Random=UnityEngine.Random;
using System;

public class SpawnManager : MonoBehaviour
{
    public GameObject modelo;
    public Transform areaSpawn; // �rea dentro de la cual se generan los personajes
    private int cantidadPersonajes; // N�mero de personajes a generar
    public  Ejercito ejercito;
    private string name;
    

    void Start()
    {
        cantidadPersonajes = ejercito.getCantidad();

        // Genera los personajes dentro del �rea especificada
        for (int i = 0; i < cantidadPersonajes; i++)
        {
            SpawnPersonaje();
        }
    }

    void SpawnPersonaje()
    {
        // Obtiene una posici�n aleatoria dentro del �rea de spawn
        Vector3 posicionAleatoria = new Vector3(
            Random.Range(areaSpawn.position.x - areaSpawn.localScale.x / 2, areaSpawn.position.x + areaSpawn.localScale.x / 2),
            areaSpawn.position.y,
            Random.Range(areaSpawn.position.z - areaSpawn.localScale.z / 2, areaSpawn.position.z + areaSpawn.localScale.z / 2)
        );

        // Instancia el personaje en la posici�n aleatoria y verifica colisiones
        UnityEngine.Collider[] colliders = Physics.OverlapSphere(posicionAleatoria, 1f);
        if (colliders.Length == 0)
        {
            GameObject nuevoPersonaje = Instantiate(modelo, posicionAleatoria, Quaternion.identity);
            // Aqu� podr�as configurar las caracter�sticas del personaje si es necesario
        }
        else
        {
            // Si hay colisiones, intenta encontrar una nueva posici�n
            SpawnPersonaje();
        }
    }
}
