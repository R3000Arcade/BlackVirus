using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moneda : MonoBehaviour
{
   
    [SerializeField] private float cantidadPuntos;

    [SerializeField] private Puntaje puntaje;
    EfectoSonido sonido;


    public void Start()
    {
        sonido = GameObject.FindGameObjectWithTag("sonido").GetComponent<EfectoSonido>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
            {
            puntaje.SumarPuntos(cantidadPuntos);
            Destroy(gameObject);
            sonido.sonidoMoneda();


        }
    }
}
