using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxneighborhood : MonoBehaviour
{
    float RotateAngle =5f;
    public float MoveSpeed = 0.0125f;
    Rigidbody2D rb;
    int BoxRotation = 1;
    int Check = 1;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position += new Vector3(MoveSpeed, 0, 0);
        // this.transform.Rotate(new Vector3(0, 0, -RotateAngle));
        /*
         if (Check == 1 && BoxRotation == 1)
         {
             rb.freezeRotation = true;
             InvokeRepeating("BoxMove", 0, 0.001f);
         }*/

        transform.position += new Vector3(MoveSpeed, 0, 0);
        this.transform.Rotate(new Vector3(0, 0, -RotateAngle));//회전

    }
    
     void BoxMove()
    {
        transform.position += new Vector3(MoveSpeed, 0, 0);
        this.transform.Rotate(new Vector3(0, 0, -RotateAngle));//회전
        BoxRotation++;
        if (BoxRotation > 50)
        {
            rb.freezeRotation = false;
            CancelInvoke("BoxMove");
            BoxRotation = 1;
        }
    }
    
}