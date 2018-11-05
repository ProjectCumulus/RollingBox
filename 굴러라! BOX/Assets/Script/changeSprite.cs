using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSprite : MonoBehaviour {
    public Sprite nextSprite;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            transform.Translate(0, 1, 0);
            gameObject.GetComponent<SpriteRenderer>().sprite = nextSprite;
        }
    }
}
