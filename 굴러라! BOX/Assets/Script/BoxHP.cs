using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.SceneManagement;


public class BoxHP : MonoBehaviour 
{ 
    public int HP = 100;
    public int Heal = 30;
    int RainD = 1;

    Restart restart;
    // Use this for initialization 

    

    void Start()
      {
        restart = GameObject.Find("덤덤이").GetComponent <Restart>();
        if (SceneManager.GetActiveScene().name == "ScriptLab")
        {
            StartCoroutine(Death());
        }
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            Debug.Log("st1");
            InvokeRepeating("Rain", 0, 0.2f);
        }
    }

    // Update is called once per frame 
    void Update()
    {
        if (HP <= 0)
        { 
            HP = 0;
            StartCoroutine(Death());
        }
        if (HP >= 100)
            HP = 100; 
      } 
  
    void Rain()
      { 
          HP-=RainD; 
      } 
    /*
    void Fire()
      { 
          HP++; 
      } */

    IEnumerator Death()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("파괴됨.");
        restart.Gameover();
        gameObject.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
      { 
        /*
         if (collision.gameObject.tag == "Fire") 
         { 
              CancelInvoke("Rain"); 
              InvokeRepeating("Fire", 0, 0.05f); 
         }  */

        if (collision.gameObject.tag == "Heal")
        {
            HP = HP + Heal;
        }

        if (collision.gameObject.tag == "WaterTrap")
        {
            HP = HP - 30;
            
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        RainD = 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
      { 
        /*
          if (collision.gameObject.tag == "Fire") 
          { 
              CancelInvoke("Fire"); 
              InvokeRepeating("Rain", 0, 0.2f); 
          }*/

        if (collision.gameObject.tag == "Umb")
        {
            RainD = 1;
        }
    } 
  } 
