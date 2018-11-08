using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxAni : MonoBehaviour
{
    public Sprite[] SPArray;
    int PresentSprite = 0;
    SpriteRenderer SR;
    bool KeyInputCheck = false;
    int RightLeftDistinction = 0;//좌우판별
    AudioSource AS;
    Rigidbody2D RB;
    float PosY = 0;
    BoxHP BoxHP;
    GameObject Player;
    PlatformerMotor2D _Motor;
    bool Freeze = true;
    // Use this for initialization
    void Start()
    {
        AS = this.GetComponent<AudioSource>();
        SR = this.GetComponent<SpriteRenderer>();
        RB = GetComponentInParent<Rigidbody2D>();
        BoxHP= GetComponentInParent<BoxHP>();
        Player = GameObject.Find("Player");
        _Motor = Player.GetComponent<PlatformerMotor2D>();
        if(SceneManager.GetActiveScene().name=="Tutorial")
        {
            _Motor.frozen = false;
            Freeze = false;
        }
        else
        {
            StartCoroutine(StageStart());
        }
        //StartCoroutine(Ani());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (BoxHP.HP > 0 && !Freeze)
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

    IEnumerator StageStart()
    {
        while(Player.transform.position.y>0.525f)
        {
            _Motor.fallFast = true;
            yield return new WaitForFixedUpdate();
        }
        _Motor.frozen = true;
        Freeze = true;
        for (int i = 0; i < 63; i++)
        {
            Player.transform.position += new Vector3(0.2f, 0, 0);
            PresentSprite++;
            if (PresentSprite > 35)
            {
                PresentSprite = 0;
            }
            SR.sprite = SPArray[PresentSprite];
            yield return new WaitForSeconds(0.04f);
        }
        Freeze = false;
        _Motor.frozen = false;
    }

    public void FLANI()
    {
        StartCoroutine(StageStart());
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
