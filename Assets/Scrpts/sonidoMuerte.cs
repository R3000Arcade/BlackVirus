using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoMuerte : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip muerto;
   

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }


    public void sonidoMuerte1()
    {
        audioSource.PlayOneShot(muerto);
    }
}
