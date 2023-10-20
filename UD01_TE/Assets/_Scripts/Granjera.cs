using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granjera : MonoBehaviour
{
    // Atributos
    public float speed = 2.0f;      // Velocidad
    float distancia = 50.0f;        // Distancia que recorrerá dentro del eje
    Vector3 inicio;                 // Posición inicial

    // Start is called before the first frame update
    void Start()
    {
        // Posición inicial de la granjera
        inicio = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Con la función PingPong la granjera se mueve en el eje z indefinidamente la distancia que le digamos
        // Cálculo de la nueva posicion
        float posicion = inicio.z - Mathf.PingPong(Time.time * speed, distancia);

        // Movimiento de la granjera
        transform.position = new Vector3(transform.position.x, transform.position.y, posicion);

    }
}
