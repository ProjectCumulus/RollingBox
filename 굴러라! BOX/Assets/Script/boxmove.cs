using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmove : MonoBehaviour
{
    public int StartPoint = 0;//스폰위치 판별 
    public float MoveSpeed = 0.02f;
    float RotateAngle = 1.8f;
    public float JumpPower = 12;
    int KeyInputCheck = 0;
    int RightLeftDistinction = 0;//좌우판별
    int BoxRotation = 1;//박스의 회전상태를 나타냄, 1일때 정지

    Rigidbody2D rb;

    private void Awake()
    {
        /*
        if(StartPoint == 0)
        {
            transform.position = new Vector3(-13, -2, 0);
        }

        if (StartPoint == 1)
        {
            transform.position = new Vector3(0, -2, 0);
        }

        if (StartPoint == 2)
        {
            transform.position = new Vector3(13, -2, 0);
        }*/
    }

    // Use this for initialization
    private void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }



// Update is called once per frame
    private void Update ()
    {

        if (Input.GetKey(KeyCode.Space)||Input.GetKey(KeyCode.W))
        {
            if (rb.velocity.y==0)
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

        if (KeyInputCheck == 1 && BoxRotation==1)
        {
            KeyInputCheck = 0;
            rb.freezeRotation = true;
            InvokeRepeating("BoxMove", 0, 0.001f);
        }

    }

    void BoxMove()
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
}
