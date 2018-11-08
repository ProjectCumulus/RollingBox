using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit : MonoBehaviour
{
    public GameObject credit1, credit2;
    // Use this for initialization
    void Start()
    {
        credit1.gameObject.SetActive(false);
        if (credit1.gameObject.activeSelf == false)
        {
            Debug.Log("비활성화");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "box2")
        {
            credit1.gameObject.SetActive(true);
            if (credit1.gameObject.activeSelf == true)
            {
                Debug.Log("활성화");
            }
            credit2.gameObject.SetActive(false);
            Debug.Log("충돌");
        }
    }
}
