using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;


public class HighStriker : MonoBehaviour
{
    public GameObject GameOver;           // result UI screen 

    public int score;                     // basic system to track score
    public ScoreManager sm;               // reference to score manager script
    private int attempts;                 // number of attempts player commits
    public AudioClip bell;                // sound effect of hitting the bell

    void start()
    {
        GameOver.SetActive(false);        // make UI as hidden
        GetComponent<AudioSource>().playOnAwake = false;    // make sure sound doesn't play
        GetComponent<AudioSource>().clip = bell;            // set source to bell
    }
    void update()                         // use this to check if game is over yet
    {
        if(attempts == 3)
        {
            GameOver.SetActive(true);           // show the game over screen and score
            sm.AddScore(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Prop"))   // see if the prop is hitting
        {
            score = Random.Range(1, 100);   // use random to generate a random score
            GameOver.SetActive(true);       // show the game over screen and score
            sm.AddScore(score);             // use the score manager script to set score
            GetComponent<AudioSource>().Play();
        }
        attempts++;
    }
}
