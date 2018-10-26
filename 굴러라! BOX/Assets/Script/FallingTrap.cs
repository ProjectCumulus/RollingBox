using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    Rigidbody2D rb;
    // Use this for initialization

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        this.gameObject.tag = "Untagged";
    }

    private void Start ()
    {
        this.gameObject.tag = "FallingTrap";
        rb.gravityScale = 1;
    }
	
	// Update is called once per frame
	void Update ()
    {

	}


    IEnumerator Broke()
    {
        yield return new WaitForSeconds(0.1f);

        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Ground")
        {
            Debug.Log("ground");
            StartCoroutine(Broke());
        }

        if (collision.tag == "Player")
        {
            Debug.Log("player");
            StartCoroutine(Broke());
        }
    }
}
