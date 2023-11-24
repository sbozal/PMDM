using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogeVida : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Recoge vida
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Se ha producido un trigger con " + other.gameObject);

        Vidas controller = other.GetComponent<Vidas>();

        if (controller != null)
        {
            controller.changeVidas(1);
            int vidas = controller.getVidas();
            Debug.Log(vidas);

        }

        Destroy(this.gameObject);
    }
}
