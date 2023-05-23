using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float inputHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        if (inputHorizontal > 0)
        {
            transform.position = transform.position + new Vector3(inputHorizontal, 0, 0) * Time.deltaTime;
        }
        else
        {
            transform.position = transform.position + new Vector3(0.09f, 0, 0) * Time.deltaTime * 20;
        }

    }
    public void Destruir()
    {
        Destroy(gameObject);
    }
}
