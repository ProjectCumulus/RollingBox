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
  
    public void HpChage(float Damage)
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
        HpChage(RainDamage);
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
            HpChage(-30);
        }

        if (collision.gameObject.tag == "WaterTrap")
        {
            HpChage(30);
        }

        if (collision.gameObject.tag == "LagerTrap")
        {
            HpChage(100);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        RainDamage = 0;
    }

    private void OnTriggerExit2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Umb")
        {
            RainDamage = 0.3f;
        }
    } 
  } 
