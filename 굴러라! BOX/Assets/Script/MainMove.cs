﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMove : MonoBehaviour
{
    public float MoveSpeed=0.75f;
	// Use this for initialization
	void Start ()
    {
        Time.timeScale =1f;
        
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        
        transform.position += new Vector3(Time.deltaTime * 60 * 0.075f, 0, 0);
        if(transform.position.x>115)
        {
            transform.position = new Vector2(-35,transform.position.y);
        }
	}
}
