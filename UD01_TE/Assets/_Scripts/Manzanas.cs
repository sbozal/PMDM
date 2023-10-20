using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manzanas : MonoBehaviour
{
    public float tiempoAparicion = 4.0f;    // Tiempo que el objeto estará visible.
    public float tiempoDesaparicion = 2.0f; // Tiempo que el objeto estará oculto.
    private bool objetoVisible = true;      // Variable para controlar la visibilidad del objeto.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objetoVisible)
        {
            // Controlar el tiempo que le objeto está visible
            tiempoAparicion -= Time.deltaTime;

            // Si el tiempo de aparición ya ha pasado, el objeto se oculta
            if (tiempoAparicion <= 0)
            {
                // Cambiamos el valor de objetoVisible
                objetoVisible = false;
                // Establecemos de nuevo el tiempo de aparición
                tiempoAparicion = 4.0f;
                // Ocultamos el objeto
                GetComponent<Renderer>().enabled = false;
            }
        }
        else
        {
            // Controlar el tiempo que el objeto está oculto
            tiempoDesaparicion -= Time.deltaTime;

            // Si el tiempo de desaparición ya ha pasado, el objeto se muestra de nuevo
            if (tiempoDesaparicion <= 0)
            {
                // Cambiamos el valor de objetoVisible
                objetoVisible = true;
                // Establecemos de nuevo el tiempo de desaparición
                tiempoDesaparicion = 2.0f; 
                // Mostramos el objeto
                GetComponent<Renderer>().enabled = true;
            }
        }
    }
}
