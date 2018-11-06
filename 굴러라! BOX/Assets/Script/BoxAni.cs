using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAni : MonoBehaviour
{
    public Sprite[] SPArray;
    int PresentSprite = 0;
    SpriteRenderer SR;
    Sprite Sprite;
    bool KeyInputCheck = false;
    int RightLeftDistinction = 0;//좌우판별
    AudioSource AS;
    Rigidbody2D RB;
    float PosY = 0;
    BoxHP BoxHP;
    // Use this for initialization
    void Start()
    {
        AS = this.GetComponent<AudioSource>();
        SR = this.GetComponent<SpriteRenderer>();
        RB = GetComponentInParent<Rigidbody2D>();
        BoxHP= GetComponentInParent<BoxHP>();
        Sprite = this.GetComponent<Sprite>();
        //StartCoroutine(Ani());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (BoxHP.HP > 0)
        {
            if (!KeyInputCheck && PresentSprite % 9 == 0)
            {
                //if (Input.GetAxis("Horizontal") > 0)
                if (Input.GetKey(KeyCode.D))
                {
                    KeyInputCheck = true;
                    RightLeftDistinction = 1;
                }

                //if (Input.GetAxis("Horizontal") < 0)
                if (Input.GetKey(KeyCode.A))
                {
                    KeyInputCheck = true;
                    RightLeftDistinction = -1;
                }
            }

            if (KeyInputCheck && PresentSprite % 9 == 0)
            {
                KeyInputCheck = false;
                //StartCoroutine(Ani());
                InvokeRepeating("BoxMove", 0, 0.04f);
            }
        }
    }

    void BoxMove()
    {
        PresentSprite += 1 * RightLeftDistinction;

        if (PresentSprite > 35)
        {
            PresentSprite = 0;
        }
        if (PresentSprite<0)
        {
            PresentSprite = 35;
        }

        SR.sprite = SPArray[PresentSprite];
        if (PresentSprite % 9 == 0)
        {
            if (RB.position.y==PosY)
            {
                AS.Play();
            }
            CancelInvoke("BoxMove");
        }
        PosY = RB.position.y;
    }
    /*
    IEnumerator Ani()
    {

        Debug.Log("cco");
        while(true)
        {
            Debug.Log(PresentSprite);
            SR.sprite = SPArray[PresentSprite];
            PresentSprite += 1 * RightLeftDistinction;
            if (PresentSprite == 36)
            {
                Debug.Log("범위초과");
                PresentSprite = 0;
            }
            if (PresentSprite == -1)
            {
                Debug.Log("범위초과");
                PresentSprite = 35;
            }
            if (PresentSprite % 9 == 0)
            {
                StopCoroutine(Ani());
            }
            yield return new WaitForSeconds(0.04f);
        }

    }
    */
}
