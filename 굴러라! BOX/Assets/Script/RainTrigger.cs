using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainTrigger : MonoBehaviour {
    public GameObject Rain, Rain_S;
    // Use this for initialization
    void Start()
    {
        Rain.gameObject.SetActive(false);
        Rain_S.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Rain.gameObject.SetActive(true);
            Rain_S.gameObject.SetActive(true);
        }
    }
}
