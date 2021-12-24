using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private AudioSource _audio;
    public AudioClip AudioClip;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>(); 
    }
    private void OnTriggerEnter(Collider other)
    {
        _audio.PlayOneShot(AudioClip);  
    }
}
