using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilAlcanzaEnemigo : MonoBehaviour
{
    GameManager gestorJuego;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Se ha producido un trigger con " + other.gameObject);
        if (other.gameObject.CompareTag("Enemy"))
        {
            Animator animator = other.GetComponent<Animator>();
            animator.SetTrigger("Muerto");
        }
        if (other.name != "Player")
        {
            Destroy(this.gameObject);
        }

        

    }
}
