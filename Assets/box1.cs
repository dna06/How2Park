using System.Collections;
using System.Collections.Generic;
using System.Media;
using UnityEngine;

public class box1 : MonoBehaviour
{ 

    public AudioClip triggerSound;
    AudioSource audioSource;

void Start()
{
    audioSource = GetComponent<AudioSource>();
}


    void OnTriggerEnter(Collider target)
    {
        if(target.tag == "Player")
        {
            audioSource.PlayOneShot(triggerSound, 0.7F);

            Debug.Log("BAAAM");


        }
       
    }

}
