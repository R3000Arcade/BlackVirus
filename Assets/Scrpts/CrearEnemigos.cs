using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigos : MonoBehaviour
{
    
    public GameObject enemigos;
    public Transform CreateEnemy;
    // Start is called before the first frame update
    void Start()
    {
        //Tiempo para activar y repetirse 
        InvokeRepeating("Crear_Enemigo", 10f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Crear_Enemigo()
    {
        Instantiate(enemigos, CreateEnemy.position, CreateEnemy.rotation);
    }
}
