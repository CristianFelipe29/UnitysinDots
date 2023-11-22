using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] personajePrefabs; // Matriz de prefabs de personajes a generar
    public Transform areaSpawn; // Área dentro de la cual se generan los personajes
    public int cantidadPersonajes = 5; // Número de personajes a generar

    void Start()
    {
        GameObject[] personajes = new GameObject[cantidadPersonajes];

        // Genera los personajes dentro del área especificada
        for (int i = 0; i < cantidadPersonajes; i++)
        {
            personajes[i] = SpawnPersonaje(personajePrefabs[i % personajePrefabs.Length]);
        }

        // Establece objetivos para que se persigan mutuamente
        for (int i = 0; i < cantidadPersonajes; i++)
        {
            int indexObjetivo = (i + 1) % cantidadPersonajes; // Siguiente personaje como objetivo
            personajes[i].GetComponent<MovimientoPersonajes>().objetivo = personajes[indexObjetivo].transform;
        }
    }

    GameObject SpawnPersonaje(GameObject prefab)
    {
        // Obtiene una posición aleatoria dentro del área de spawn
        Vector3 posicionAleatoria = new Vector3(
            Random.Range(areaSpawn.position.x - areaSpawn.localScale.x / 2, areaSpawn.position.x + areaSpawn.localScale.x / 2),
            areaSpawn.position.y,
            Random.Range(areaSpawn.position.z - areaSpawn.localScale.z / 2, areaSpawn.position.z + areaSpawn.localScale.z / 2)
        );

        // Instancia el personaje en la posición aleatoria y verifica colisiones
        Collider[] colliders = Physics.OverlapSphere(posicionAleatoria, 1f);
        if (colliders.Length == 0)
        {
            GameObject nuevoPersonaje = Instantiate(prefab, posicionAleatoria, Quaternion.identity);
            return nuevoPersonaje;
        }
        else
        {
            // Si hay colisiones, intenta encontrar una nueva posición
            return SpawnPersonaje(prefab);
        }
    }
}




