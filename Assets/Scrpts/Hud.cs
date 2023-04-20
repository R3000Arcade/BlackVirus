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
        vidas = this.GetComponentsInChildren<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DesactivaeVida(int indice)
    {
       
        int a = (vidas.Length == 0) ? 0 : vidas.Length; 

       for (int i = 0; i < vidas.Length; i++)
        {
            string b = vidas[i].ToString();
        }
        
    }
    public void ActivarVida(int indice)
    {
        vidas[indice].SetActive(true);
    }
}
