using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DunkTank : MonoBehaviour
{
    public AudioClip bell;                // sound effect of hitting the bell
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;    // make sure sound doesn't play
        GetComponent<AudioSource>().clip = bell;            // set source to bell
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Prop"))   // see if the prop is hitting
        {
            //score = Random.Range(1, 100);   // use random to generate a random score
         
            GetComponent<AudioSource>().Play();             // play source
        }
    }
}
