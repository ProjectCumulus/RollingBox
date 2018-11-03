using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    public bool Able_Destroy = true;
    Rigidbody2D rb;
    bool wf = true;
    public float FallSpeed = 0.3f;
    float FallVelocity = 0;
    // Use this for initialization

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        this.gameObject.tag = "Untagged";
    }

    private void Start ()
    {
        this.gameObject.tag = "FallingTrap";
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
            FallVelocity -= FallSpeed * Time.deltaTime * 60 * Global.TheWorld;
            rb.velocity = new Vector2(0, FallVelocity* Global.TheWorld);
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
