using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noise : MonoBehaviour {


    public AudioClip makeNoise1;
    public AudioClip makeNoise2;
    AudioSource sound1;
    AudioSource sound2;
    

    // Use this for initialization
    void Start () {
        
      
	}
	

    void Noise1(){
        sound1 = GetComponent<AudioSource>();
        sound1.PlayOneShot(makeNoise1, 0.6f);

    }

    void Noise2()
    {
        sound2 = GetComponent<AudioSource>();
        sound2.PlayOneShot(makeNoise2, 0.6f);

    }
}
