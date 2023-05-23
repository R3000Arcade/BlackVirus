using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoter : MonoBehaviour
{
    public Transform controlDisparo;
    public GameObject disparo;
    public GameObject UltraDisparo;
   
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
           
        }
       

    }

  

    private void Disparar()
    {
        Instantiate(disparo, controlDisparo.position, controlDisparo.rotation);
        
    }
    
}
