using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    public float TriggerPositionX = -2;
    FallingTrap Fall;
    bool Usable;
    public GameObject target;
    // Use this for initialization
    private void Awake()
    {
        Usable = true;
        Fall = GetComponentInParent<FallingTrap>();
        Fall.enabled = false;
        this.transform.parent = null;
        transform.position = new Vector2(Fall.transform.position.x+TriggerPositionX, 5);
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
        if(Usable)
        {
            if(collision.tag=="Player")
            {
                Debug.Log("충돌");
                Fall.enabled = true;
                Usable = false;
            }
        }
    }
}
