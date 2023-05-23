using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public float velocidad;
    public float danio;
    Enemy enemigo;
     EnemyIzquierda enemy2;
    int time;
    // Start is called before the first frame update
    void Start()
    {
        enemigo = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Enemy>();
        enemy2 = GameObject.FindGameObjectWithTag("Enemy2").GetComponent<EnemyIzquierda>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);// MOVER
        time++;
        if(time == 50)
        {
            Destroy(gameObject);
            time = 0;
        }



    }
    private void OnCollisionEnter2D(Collision2D collition)
    {
        if (collition.gameObject.tag == "Player")
        {
           

            Destroy(gameObject);

        }
        if (collition.gameObject.tag == "Enemy2")
        {
            Destroy(gameObject);
            enemy2.Destruir();
            

            
        }

    }

}
