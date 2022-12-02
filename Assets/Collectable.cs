using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Collectable : MonoBehaviour
{
    public AudioClip collect;
    public AudioSource sfxPlayer;

    //public static event Action OnCollected;
    public static int total;

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {   
            sfxPlayer.PlayOneShot(collect);
            Destroy(gameObject);
            
            

        }
    }
}
