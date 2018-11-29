using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTrigger : MonoBehaviour
{
    Fade Black;
    TimeStop TimeStop;

    // Use this for initialization
    void Start ()
    {
        Black = GameObject.Find("Black").GetComponent<Fade>();
        TimeStop = GameObject.Find("UI").GetComponent<TimeStop>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            TimeStop.Ending();
            Black.FadeOut();
        }
    }
}
