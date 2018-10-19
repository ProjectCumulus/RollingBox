using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroll : MonoBehaviour
{
    GameObject player;
	// Use this for initialization
	void Start ()
    {
        this.player = GameObject.Find("Box");
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        Vector3 playerPros = this.player.transform.position;
        transform.position = new Vector3(playerPros.x,transform.position.y, transform.position.z);
	}
}
