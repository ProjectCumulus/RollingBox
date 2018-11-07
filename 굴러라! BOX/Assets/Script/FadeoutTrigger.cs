using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeoutTrigger : MonoBehaviour {
    public GameObject Fadeout;
    // Use this for initialization
    void Start () {
        Fadeout.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Fadeout.gameObject.SetActive(true);
        }
    }
}
