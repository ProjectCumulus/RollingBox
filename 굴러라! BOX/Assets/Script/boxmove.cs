using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmove : MonoBehaviour
{
    //public float MoveSpeed = 0.02f;
    //float RotateAngle = 1.8f;
    //public float JumpPower = 16;
   // int KeyInputCheck = 0;
   // int RightLeftDistinction = 0;//좌우판별
   // int BoxRotation = 1;//박스의 회전상태를 나타냄, 1일때 정지
   // bool JumpAble = true;

    Rigidbody2D rb;
    public float MoveSpeed = 0.05f;
    private void Awake()
    {

    }

    // Use this for initialization
    private void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
    }



// Update is called once per frame
    private void Update ()
    {
        //transform.position += new Vector3(RightLeftDistinction * MoveSpeed, 0, 0);//이동

        transform.position += new Vector3(Time.deltaTime * 60 *0.075f, 0, 0);
    }

    /*
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W))
        {
            if (JumpAble)
            {
                rb.velocity = new Vector2(rb.velocity.x, JumpPower);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (KeyInputCheck == 0 && BoxRotation == 1)
            {
                KeyInputCheck = 1;
                RightLeftDistinction = 1;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (KeyInputCheck == 0 && BoxRotation == 1)
            {
                KeyInputCheck = 1;
                RightLeftDistinction = -1;
            }
        }

        if (KeyInputCheck == 1 && BoxRotation == 1)
        {
            KeyInputCheck = 0;
            rb.freezeRotation = true;
            InvokeRepeating("BoxMove", 0, 0.001f);
        }

    }
    */
    /*
     * void BoxMove()
    {
        transform.position += new Vector3(RightLeftDistinction * MoveSpeed , 0, 0);//이동
        this.transform.Rotate(new Vector3(0, 0, RightLeftDistinction * -RotateAngle));//회전
        BoxRotation++;
        if(BoxRotation>50)
        {
            rb.freezeRotation = false;
            CancelInvoke("BoxMove");
            BoxRotation = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==8)
        {
            JumpAble = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            JumpAble = false;
        }
    }
    */
}
