using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagersMove : MonoBehaviour
{
    public GameObject A, B, C, D, E;
    // Use this for initialization
    void Start()
    {
        A.gameObject.SetActive(false);
        B.gameObject.SetActive(false);
        C.gameObject.SetActive(false);
        D.gameObject.SetActive(false);
        E.gameObject.SetActive(false);
        /*
        A.GetComponent<boxneighborhood>().enabled = false;
        A.GetComponent<BoxCollider2D>().enabled = false;


        B.GetComponent<boxneighborhood>().enabled = false;
        B.GetComponent<BoxCollider2D>().enabled = false;

        C.GetComponent<boxneighborhood>().enabled = false;
        C.GetComponent<BoxCollider2D>().enabled = false;

        D.GetComponent<boxneighborhood>().enabled = false;
        D.GetComponent<BoxCollider2D>().enabled = false;

        E.GetComponent<boxneighborhood>().enabled = false;
        E.GetComponent<BoxCollider2D>().enabled = false;

        */
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x> 32.0f)
        {
            A.gameObject.SetActive(true);
            /*
            A.GetComponent<boxneighborhood>().enabled = true;
            A.GetComponent<BoxCollider2D>().enabled = true;
            */
        }

        if (transform.position.x > 48.0f)
        {
            B.gameObject.SetActive(true);
           // B.GetComponent<boxneighborhood>().enabled = true;
            //B.GetComponent<BoxCollider2D>().enabled = true;
        }
        if (transform.position.x > 67.0f)
        {
            C.gameObject.SetActive(true);
            //C.GetComponent<boxneighborhood>().enabled = true;
            //C.GetComponent<BoxCollider2D>().enabled = true;
        }
        if (transform.position.x > 82.0f)
        {
            D.gameObject.SetActive(true);
            //D.GetComponent<boxneighborhood>().enabled = true;
            //D.GetComponent<BoxCollider2D>().enabled = true;
        }
        if (transform.position.x > 100.0f)
        {
            E.gameObject.SetActive(true);
           // E.GetComponent<boxneighborhood>().enabled = true;
            //E.GetComponent<BoxCollider2D>().enabled = true;
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
