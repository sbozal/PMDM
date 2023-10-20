using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{
    // Atributos
    public Transform target;        // Objeto sobre el que vamos a girar
    public int speed;               // Velocidad de giro

    // Start is called before the first frame update
    void Start()
    {
        // Comprobar si target es nulo
        if (target == null)
        {
            target = this.gameObject.transform;

        }
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime *-1);
    }
}
