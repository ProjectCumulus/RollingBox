using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTrigger : MonoBehaviour {
    public GameObject Keys;
    // Use this for initialization
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Keys.gameObject.SetActive(false);
        }
    }
}
