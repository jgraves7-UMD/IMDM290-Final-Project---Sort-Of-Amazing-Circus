using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonPop : MonoBehaviour
{
    public GameObject balloon;         // balloon source
    public AudioClip pop;       // audio source

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;    // make sure sound doesn't play
        GetComponent<AudioSource>().clip = pop;            // set source to balloon pop
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))   // see if the prop is hitting
        {
            //score = Random.Range(1, 100);   // use random to generate a random score
            balloon.SetActive(false);         // hide
            GetComponent<AudioSource>().Play();             // play source
        }
        //attempts++;
    }
}
