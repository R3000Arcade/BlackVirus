using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoSonido : MonoBehaviour


{
    private AudioSource audioSource;
    [SerializeField] private AudioClip colectar1;
    [SerializeField] private AudioClip colectar2;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }
 

    public void sonidoMoneda()
    {
        audioSource.PlayOneShot(colectar1);
    }
}
