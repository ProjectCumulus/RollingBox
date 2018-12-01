using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
    Fade Black;
    public Text Game_Over;

    // Use this for initialization
    void Start () {
        Black = GameObject.Find("Black").GetComponent<Fade>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Game_Over.text = "Game Over";
            Debug.Log("떴따");
        }
    }
}
