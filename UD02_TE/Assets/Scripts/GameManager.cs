using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Interfaz
    public Text textoVidas;
    public Text textoGana;
    public Text textoPierde;
    public Button reiniciar;

    // Configuración
    public int numVidas = 3;

    
    // Start is called before the first frame update
    void Start()
    {
        textoGana.enabled = false;
        textoPierde.enabled = false;
        reiniciar.gameObject.SetActive(false);

        textoVidas.text = "Vidas: " + numVidas;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] listaEnemigos = GameObject.FindGameObjectsWithTag("Enemy");
        if(listaEnemigos.Length == 0)
        {
            FinJuego(true);
        }
    }

    public void ActualizarContador(int vidas)
    {
        textoVidas.text = "Vidas: " + vidas;
    }


    public void FinJuego(bool ganar)
    {
        Debug.Log("Enemigos3");
        if (ganar)
        {
            Debug.Log("Enemigos4");
            textoGana.enabled = true;
        }
        else
        {
            textoPierde.enabled = true;

        }
        
        reiniciar.gameObject.SetActive(true);

    }
}
