using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditControl : MonoBehaviour
{
    public GameObject Box;
    public GameObject N_Box1;
    public GameObject N_Box2;
    public GameObject N_Box3;
    public GameObject N_Box4; 
    public GameObject N_Box5;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void Looped_Move()
    {
        Box.transform.position -= new Vector3(80, 0, 0);
        N_Box1.transform.position -= new Vector3(80, 0, 0);
        N_Box2.transform.position -= new Vector3(80, 0, 0);
        N_Box3.transform.position -= new Vector3(80, 0, 0);
        N_Box4.transform.position -= new Vector3(80, 0, 0);
        N_Box5.transform.position -= new Vector3(80, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Looped_Move();
        }
    }
}
