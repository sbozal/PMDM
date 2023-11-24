using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemigoSiguePlayer : MonoBehaviour
{
    public Transform objetivo = null;
    float velocidad = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PosicionEnemigo();
    }

    private void PosicionEnemigo()
    {
        if (objetivo != null)
        {
            transform.position = new Vector3(Mathf.Lerp(transform.position.x, objetivo.position.x, Time.deltaTime * velocidad), Mathf.Lerp(transform.position.y, objetivo.position.y, Time.deltaTime * velocidad), transform.position.z);
        }
    }
}
