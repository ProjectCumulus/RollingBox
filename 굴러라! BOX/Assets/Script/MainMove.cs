using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMove : MonoBehaviour
{
    public float MoveSpeed=0.1f;

	// Use this for initialization
	void Start ()
    {
        Time.timeScale =1f;
	}

    void Update()
    {
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        transform.position += new Vector3(Time.deltaTime * 60 * MoveSpeed, 0, 0);
        if(transform.position.x>105)
        {
            transform.position = new Vector2(-35,transform.position.y);
        }
	}
}
