using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBurbuja : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private AudioClip burbuja;


    public void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }


    public void sonidoBurbuja2()
    {
        audioSource.PlayOneShot(burbuja);
    }
}
