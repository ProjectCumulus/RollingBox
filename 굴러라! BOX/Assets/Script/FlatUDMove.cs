using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatUDMove : MonoBehaviour
{
    float y;
    Rigidbody2D rb;
    public int UDD = 2;//속도
    public int Range = 5;//범위


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = (new Vector2(0, UDD));

        if (this.transform.position.y - y < -Range)
        {
            UDD = 2;
        }

        if (this.transform.position.y - y > Range)
        {
            UDD = -2;
        }
    }
}
