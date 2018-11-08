using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boxmove : MonoBehaviour
{
    //public float MoveSpeed = 0.02f;
    //float RotateAngle = 1.8f;
    //public float JumpPower = 16;
    // int KeyInputCheck = 0;
    // int RightLeftDistinction = 0;//좌우판별
    // int BoxRotation = 1;//박스의 회전상태를 나타냄, 1일때 정지
    // bool JumpAble = true;
    AudioSource AS;
    Rigidbody2D rb;
    int BoxR = 0;
    public float MoveSpeed = 0.0125f;
    private void Awake()
    {

    }

    // Use this for initialization
    void Start()
    {
        AS = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position += new Vector3(RightLeftDistinction * MoveSpeed, 0, 0);//이동

        transform.position += new Vector3(MoveSpeed, 0, 0);
        this.transform.Rotate(new Vector3(0, 0, -5));
        BoxR++;
        if(BoxR%14==0)
        {
            BoxR = 0;
            AS.Play();
        }
        /*
        if (transform.position.x > 105)
        {
            transform.position = new Vector2(-28, transform.position.y);
        }
        */
        if (SceneManager.GetActiveScene().name == "Ending")
        {
            if (transform.position.x > 105)
            {
                transform.position = new Vector2(-25, transform.position.y);
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "GoEnd")
        {
            StartCoroutine(Credit());
        }
    }

    IEnumerator Credit()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Ending");

    }
}

         
    
