﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextON : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.gameObject.GetComponent<SpriteRenderer>().color += new Color(0, 0, 0, Time.deltaTime / 0.3f);
    }
}
