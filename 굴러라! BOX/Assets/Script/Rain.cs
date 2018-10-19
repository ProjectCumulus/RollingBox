using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    GameObject player;
    
    void Start()
    {
        this.player = GameObject.Find("Box");
    }

    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(
        playerPos.x, transform.position.y, transform.position.z);

    }
}
