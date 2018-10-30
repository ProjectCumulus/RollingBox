using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.SceneManagement;


public class BoxHP : MonoBehaviour 
{ 
    public float HP = 100;
    float RainDamage = 0.3f;


    boxmove Boxmove;
    Restart restart;
    SimpleHealthBar HpBar;
    // Use this for initialization 



    void Start()
    {
        restart = GameObject.Find("덤덤이").GetComponent <Restart>();
        HpBar=GameObject.Find("Status Fill 00").GetComponent<SimpleHealthBar> ();
        Boxmove = GameObject.Find("Box").GetComponent<boxmove>();
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

    } 
  
    public void HpChange(float Damage)
    {
        HP -= Damage;
        if (HP <= 0)
        {
            HP = 0;
            StartCoroutine(Death());
        }
        if (HP >= 100)
        {
            HP = 100;
        }
        HpBar.UpdateBar(HP, 100);
    }

    void Rain()
    {
        HpChange(RainDamage);
    } 

    void Poison()
    {
        Debug.Log("Poison");
        HpChange(2);
    }

    void PoisonEnd()
    {
        CancelInvoke("Poison");
    }

    IEnumerator Death()
    {
        Boxmove.enabled = false;
        yield return new WaitForSeconds(2f);
        Debug.Log("파괴됨.");
        restart.Gameover();
    }

    private void OnTriggerEnter2D(Collider2D collision)
      { 

        if (collision.gameObject.tag == "Heal")
        {
            HpChange(-30);
        }

        if (collision.gameObject.tag == "WaterTrap")
        {
            HpChange(30);
        }

        if (collision.gameObject.tag == "FallingTrap")
        {
            HpChange(30);
        }

        if (collision.gameObject.tag == "LagerTrap")
        {
            HpChange(100);
        }

        if (collision.gameObject.tag == "PoisonGas")
        {
            InvokeRepeating("Poison", 0.5f, 0.5f);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Umb")
        {
            RainDamage = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Umb")
        {
            RainDamage = 0.3f;
        }

        if (collision.gameObject.tag == "PoisonGas")
        {
            Invoke("PoisonEnd", 2.5f);
        }
    } 
  } 
