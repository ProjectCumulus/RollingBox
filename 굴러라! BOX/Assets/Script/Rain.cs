using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
    public GameObject Player;
    bool Mapout = false;
    Animator Ani;
    void Start()
    {
        Ani = GetComponent<Animator>();
    }

    void Update()
    {
        Ani.speed = Global.TheWorld;
    }

    void LateUpdate()
    {
        /*
        if (!Mapout)
        {
            transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        if (this.transform.position.x < 15)
        {
            Mapout = true;
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        else
            Mapout = false;*/
    }

}
