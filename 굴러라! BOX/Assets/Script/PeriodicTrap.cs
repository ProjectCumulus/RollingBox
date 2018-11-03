using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodicTrap : MonoBehaviour {

    Animator Ani;

	// Use this for initialization
	void Start ()
    {
        Ani=GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Ani.speed=Global.TheWorld;
	}
}
