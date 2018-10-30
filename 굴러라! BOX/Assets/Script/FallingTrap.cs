using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    public bool Able_Destroy = true;
    Rigidbody2D rb;
    bool wf = true;
    public float FallSpeed = 0.3f;
    // Use this for initialization

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        this.gameObject.tag = "Untagged";
    }

    private void Start ()
    {
        this.gameObject.tag = "FallingTrap";
        //rb.gravityScale = 1;
        StartCoroutine(Fall());
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    IEnumerator Fall()
    {

        while(wf)
        {
            rb.velocity -= new Vector2(0, Time.deltaTime * 60 * FallSpeed);
            if(transform.position.y<0)
            {
                this.gameObject.tag = "Untagged";
                wf = false;
                rb.velocity = new Vector2(0, 0);
                transform.position = new Vector2(transform.position.x, 0.5f);
                if (Able_Destroy)
                {
                    StartCoroutine(Broke());
                }
            }
            yield return new WaitForFixedUpdate();
        }
    }

    IEnumerator Broke()
    {
        yield return new WaitForSeconds(0.1f);

        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Able_Destroy)
        {
            if (collision.tag == "Player")
            {
                Debug.Log("player");
                StartCoroutine(Broke());
            }
        }
    }
}
