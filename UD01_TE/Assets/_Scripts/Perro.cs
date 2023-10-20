using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perro : MonoBehaviour 
{
    // Atributos
    public Transform target;        // Objeto sobre el que vamos a girar. En este caso la granjera
    public int speed;               // Velocidad de desplazamiento
    public int radio;               // Radio de la circunferencia

    // Start is called before the first frame update
    void Start()
    {
        // Comprobar si target es nulo
        if(target == null)
        {
            target = this.gameObject.transform;

        }

    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento
        // Cálculo de la nueva posición
        Vector3 posicion = new Vector3
            (
                target.position.x + Mathf.Cos(Time.time * speed) * radio,
                transform.position.y,
                target.position.z + Mathf.Sin(Time.time * speed) * radio
            );

        // Poner objeto en la posición calculada
        transform.position = posicion;
    }
}
