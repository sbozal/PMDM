using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perro : MonoBehaviour 
{

    public Transform target;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        // Comprobar si target es nulo
        if(target == null)
        {
            target = this.gameObject.transform;
            Debug.log("Target nulo.")
        }
        Debug.log("Iniciado " + this.name);
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
        Debug.log("Actualizado " + this.name);
    }
}
