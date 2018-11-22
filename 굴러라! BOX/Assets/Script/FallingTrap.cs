﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FallingTrap : MonoBehaviour
{
   // public AudioClip BreakSound;  //유리깨지는소리
    //public AudioClip fallsound;     //책떨어지는소리
   // public AudioClip knifesound; //칼 떨어지는 소리

    public bool Able_Destroy = true;
    Rigidbody2D rb;
    bool wf = true;
    public float FallSpeed = 0.2f;
    float FallVelocity = 0;
    soundManager SM;
    public AudioClip Clip;
    // Use this for initialization

    private void Awake()
    {
        SM = GameObject.Find("SoundManager").GetComponent<soundManager>();
        rb = GetComponent<Rigidbody2D>();
        this.gameObject.tag = "Untagged";

     
    }

    private void Start ()
    {
        this.gameObject.tag = "FallingTrap";
        StartCoroutine(Fall());
    }

    // Update is called once per frame
    void Update ()
    {

    }

    IEnumerator Fall()
    {
        while (wf)
        {
            FallVelocity -= FallSpeed * Time.deltaTime * 60 * Global.TheWorld;
            rb.velocity = new Vector2(0, FallVelocity* Global.TheWorld);
            if(transform.position.y<0.95)
            {
                this.gameObject.tag = "Untagged";
                wf = false;
                if (Able_Destroy)
                {
                    StartCoroutine(Broke());
                }
                else
                {
                    SM.Play(Clip);
                    rb.velocity = new Vector2(0, 0);
                    transform.position = new Vector2(transform.position.x, 0.35f);
                }
            }
            
            yield return new WaitForFixedUpdate();
        }
    }

    IEnumerator Broke()
    {
        SM.Play(Clip);
        yield return new WaitForSeconds(0.05f);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Able_Destroy)
        {
            if (collision.tag == "Player")
            {
                Debug.Log("player");
                StartCoroutine(Broke());
            }
        }
    }

}
