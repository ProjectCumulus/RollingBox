using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour {
    public GameObject KeyA, KeyD;
    // Use this for initialization
    void Start()
    {
       KeyA.gameObject.SetActive(false);
       KeyD.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            KeyA.gameObject.SetActive(true);
            KeyD.gameObject.SetActive(true);
        }
    }
}
