using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxmove : MonoBehaviour
{
    public int HP = 100;
    float MoveSpeed = 0.02f;
    float RotateAngle = 1.8f;
    public float JumpPower = 30;
    int KeyInputCheck = 0;
    int RightLeftDistinction = 0;//좌우판별
    int BoxRotation = 1;//박스의 회전상태를 나타냄, 1일때 정지
    public bool BoxOnGround = true;//상자가 땅에 있는지 떠있는지 판별함.

    Rigidbody2D rb;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }



// Update is called once per frame
    void Update ()
    {

        if (BoxOnGround==true&&Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpPower);
            BoxOnGround = false;
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
            CancelInvoke();
            BoxRotation = 1;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            BoxOnGround = false;
        }
    }//땅에서 벗어났을 때 점프를 못하게함

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==8)
        {
            BoxOnGround = true;
        }
    }//땅에 닿았을 때 점프를 다시 할 수 있게 만들어줌
}
