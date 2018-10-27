using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    FallingTrap Fall;
    bool Usable = true;
    // Use this for initialization
    private void Awake()
    {
        Fall = GetComponentInParent<FallingTrap>();
        Fall.enabled = false;
        this.transform.parent = null;
        transform.position = new Vector2(Fall.transform.position.x - 2, 0.5f);
    }

    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Usable==true)
        {
            if(collision.tag=="Player")
            {
                Fall.enabled = true;
                Usable = false;
            }
        }
    }
}
