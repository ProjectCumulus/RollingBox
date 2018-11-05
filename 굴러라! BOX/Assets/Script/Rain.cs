using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour
{
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

    }

}
