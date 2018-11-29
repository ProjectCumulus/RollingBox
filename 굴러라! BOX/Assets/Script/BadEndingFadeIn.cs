using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadEndingFadeIn : MonoBehaviour {
    Fade Black;

    // Use this for initialization
    void Start()
    {
        Black = GameObject.Find("Black").GetComponent<Fade>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("In");
            Black.FadeIn();

        }
    }
}
