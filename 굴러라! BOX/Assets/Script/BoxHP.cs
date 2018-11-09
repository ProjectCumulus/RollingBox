using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.SceneManagement;


public class BoxHP : MonoBehaviour 
{
    public float HP = 100;
    float RainDamage = 0;
    bool BoxLive = true;
    public AudioClip HealSound;
    public AudioClip DamagedSound;
    public AudioClip DeathSound;
    public GameObject Player;
    PlatformerMotor2D _Motor;
    Restart restart;
    public GameObject BGMPlayer;
    SimpleHealthBar HpBar;
    soundManager SM;
    // Use this for initialization 



    void Start()
    {
        SM = GameObject.Find("BoxSoundManager").GetComponent<soundManager>();
        restart = GameObject.Find("덤덤이").GetComponent <Restart>();
        HpBar =GameObject.Find("HPBar").GetComponent<SimpleHealthBar> ();
        _Motor = Player.GetComponent<PlatformerMotor2D>();
        BGMPlayer.GetComponent<AudioSource>().volume = 1;
        if (SceneManager.GetActiveScene().name == "ScriptLab")
        {
            //StartCoroutine(Death());
        }
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            Rain();
        }


        HpBar.UpdateBar(HP, 100);
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
            if (BoxLive == true)
            {
                StartCoroutine(Death());
            }
        }
        if (HP >= 100)
        {
            HP = 100;
        }
        HpBar.UpdateBar(HP, 100);
    }

    public void Rain()
    {
        RainDamage = 0.3f;
        StartCoroutine(RainingToday());
    } 

    IEnumerator RainingToday()
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            HpChange(RainDamage * Global.TheWorld);
        }
    }

    void Poison()
    {
        Debug.Log("Poison");
        HpChange(2);
        SM.Play(DamagedSound);
    }

    void PoisonEnd()
    {
        CancelInvoke("Poison");
    }

    IEnumerator Death()
    {
        BoxLive = false;
        SM.Play(DeathSound);
        _Motor.frozen = true;
        for(int i=0; i<30; i++)
        {
            BGMPlayer.GetComponent<AudioSource>().volume -= 0.025f;
            yield return new WaitForSeconds(0.05f);
        }
        Debug.Log("파괴됨.");
        restart.Gameover();
    }

    private void OnTriggerEnter2D(Collider2D collision)
      { 

        if (collision.gameObject.tag == "Heal")
        {
            HpChange(-30);
            SM.Play(HealSound);
        }
       

        if (collision.gameObject.tag == "WaterTrap")
        {
            HpChange(25);
            SM.Play(DamagedSound);
        }

        if (collision.gameObject.tag == "FallingTrap")
        {
            HpChange(30);
            SM.Play(DamagedSound);
        }

        if (collision.gameObject.tag == "LagerTrap")
        {
            
            HpChange(100);
        }

        if (collision.gameObject.tag == "PoisonGas")
        {
            InvokeRepeating("Poison", 0.5f, 0.5f);
        }

        if (collision.gameObject.tag == "Spike")
        {
            HpChange(20);
            SM.Play(DamagedSound);
        }

        if (collision.gameObject.tag == "Mine")
        {
            HpChange(100);
        }

        if (collision.gameObject.tag == "Sword")
        {
            HpChange(30);
            SM.Play(DamagedSound);
        }

        if (collision.gameObject.tag == "tutorialdam")
        {
            Invoke("Cliff", 0.8f);
        }
    }

    void Cliff()
    {
        HpChange(90);
        SM.Play(DamagedSound);
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
