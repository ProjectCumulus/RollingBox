using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroll : MonoBehaviour
{
    public GameObject target;
    bool Mapout = false;
	// Use this for initialization
	void Start ()
    {
        //this.Box = GameObject.Find("Box");
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (!Mapout)
        {
            transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        if(this.transform.position.x<15)
        {
            Mapout = true;
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        else
            Mapout = false;
    }
}
