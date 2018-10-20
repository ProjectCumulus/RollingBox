﻿using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 
 
public class BoxHP : MonoBehaviour 
{ 
    public int HP = 100;
    //Restart restart;
    // Use this for initialization 

    private void Awake()
    {
        /*
        restart = null;
        restart = GameObject.Find("RestartManager").GetComponent<Restart>();
        */

    }

    void Start()
      { 
          InvokeRepeating("Rain", 0, 0.2f); 
      }

    // Update is called once per frame 
    void Update()
    {
        if (HP <= 0)
        { 
            HP = 0;
            Death();
        }
        if (HP >= 100)
            HP = 100; 
      } 
  
    void Rain()
      { 
          HP--; 
      } 
  
    void Fire()
      { 
          HP++; 
      } 

    void Death()
    {
        gameObject.SetActive(false);
        Debug.Log("파괴됨.");
        //restart.SceneRestart();
    }

    private void OnTriggerEnter2D(Collider2D collision)
      { 
         if (collision.gameObject.tag == "Fire") 
          { 
              CancelInvoke("Rain"); 
              InvokeRepeating("Fire", 0, 0.05f); 
          } 
  
 
          if (collision.gameObject.tag == "Umb") 
          { 
              CancelInvoke("Rain"); 
         } 
      } 
  
      private void OnTriggerExit2D(Collider2D collision)
      { 
          if (collision.gameObject.tag == "Fire") 
          { 
              CancelInvoke("Fire"); 
              InvokeRepeating("Rain", 0, 0.2f); 
          } 
 
          if (collision.gameObject.tag == "Umb") 
          { 
             InvokeRepeating("Rain", 0, 0.2f); 
          } 
      } 
  } 
