using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerSound : MonoBehaviour
{
    public AudioClip Clip;
    soundManager SM;

    // Use this for initialization
    private void Awake()
    {
        SM = GameObject.Find("SoundManager").GetComponent<soundManager>();
    }

    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SM.Play(Clip);
        }
    }
}
