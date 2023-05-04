using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class Puntaje : MonoBehaviour
{
    private float puntos;

    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();

    }
    private void Update()
    {
       
        textMesh.text = puntos.ToString("0");
    }

    public void SumarPuntos (float puntosEntrada)
    {
        puntos += puntosEntrada;
        if (puntos >= 670)
        {
            SceneManager.LoadScene("MenuInicial", LoadSceneMode.Single);
        }

    }
}
