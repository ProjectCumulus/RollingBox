using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodicTrap : MonoBehaviour {

    Animator Ani;
    AudioSource AS;
	// Use this for initialization
	void Start ()
    {
        AS = GetComponent<AudioSource>();
        Ani=GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Ani.speed=Global.TheWorld;
	}

    void Play()
    {
        AS.Play();
    }
}
