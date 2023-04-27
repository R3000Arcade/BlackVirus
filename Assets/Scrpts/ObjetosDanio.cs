using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosDanio : MonoBehaviour
{
    public GameManager gameManager;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameManager.PerderVidas();
        }
        
    }
}
