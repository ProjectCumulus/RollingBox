using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.SceneManagement;


public class BoxHP : MonoBehaviour 
{ 
    public float HP = 100;
    public int Heal = 30;
    float RainD = 0.3f;

    Restart restart;
    SimpleHealthBar HpBar;
    // Use this for initialization 



    void Start()
    {
        restart = GameObject.Find("덤덤이").GetComponent <Restart>();
        HpBar=GameObject.Find("Status Fill 00").GetComponent<SimpleHealthBar> ();
        if (SceneManager.GetActiveScene().name == "ScriptLab")
        {
            //StartCoroutine(Death());
        }
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            InvokeRepeating("Rain", 0, 0.1f);
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

        HpBar.UpdateBar(HP, 100);
    } 
  
    void Rain()
      { 
          HP-=RainD; 
      } 

    IEnumerator Death()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("파괴됨.");
        restart.Gameover();
        gameObject.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
      { 

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
        if (collision.gameObject.tag == "Umb")
        {
            RainD = 0.3f;
        }
    } 
  } 
