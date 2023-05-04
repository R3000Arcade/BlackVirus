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
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            audioSource.PlayOneShot(colectar1);
        }
    }
}
