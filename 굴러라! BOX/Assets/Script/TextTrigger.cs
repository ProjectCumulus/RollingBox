using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour {
    public GameObject Text, Text_B;
    // Use this for initialization
    void Start () {
        Text.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Text.gameObject.SetActive(true);
            Text_B.gameObject.SetActive(false);

        }
    }
}
