using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroll : MonoBehaviour
{
    GameObject Box;
    bool Mapout = false;
	// Use this for initialization
	void Start ()
    {
        this.Box = GameObject.Find("Box");
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (!Mapout)
        {
            transform.position = new Vector3(Box.transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(13, transform.position.y, transform.position.z);
        }
        if(this.transform.position.x<13)
        {
            Mapout = true;
            transform.position = new Vector3(13, transform.position.y, transform.position.z);
        }
        else
            Mapout = false;
    }
}
