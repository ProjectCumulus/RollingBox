using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagersMove : MonoBehaviour
{
    public GameObject A, B, C, D, E;
    // Use this for initialization
    void Start()
    {
        A.GetComponent<boxneighborhood>().enabled = false;
        B.GetComponent<boxneighborhood>().enabled = false;
        C.GetComponent<boxneighborhood>().enabled = false;
        D.GetComponent<boxneighborhood>().enabled = false;
        E.GetComponent<boxneighborhood>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x> 34.0f)
        {
            A.GetComponent<boxneighborhood>().enabled = true;
        }

        if (transform.position.x > 47.0f)
        {
            B.GetComponent<boxneighborhood>().enabled = true;
        }
        if (transform.position.x > 63.0f)
        {
            C.GetComponent<boxneighborhood>().enabled = true;
        }
        if (transform.position.x > 76.0f)
        {
            D.GetComponent<boxneighborhood>().enabled = true;
        }
        if (transform.position.x > 92.0f)
        {
            E.GetComponent<boxneighborhood>().enabled = true;
        }
    }

    /*
     void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "box1")
        {
         
        }
    }
    */
}
