using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hud : MonoBehaviour
{
    public GameObject[] vidas;

    // Start is called before the first frame update
    void Start()
    {
        //vidas = this.GetComponentsInChildren<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DesactivaeVida(int indice)
    {
        vidas[indice].SetActive(false);
        
    }
    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
}
