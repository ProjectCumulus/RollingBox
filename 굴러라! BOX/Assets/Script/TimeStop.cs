using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class Global
{
    public static float TheWorld = 1;
}

public class TimeStop : MonoBehaviour
{
    GameObject TimeEffect;
    public Text Text;
    SimpleHealthBar TimeGauge;
    bool Delay = false;
    float GaugeMax = 100;
    float GaugeNow = 100;
    float GaugeAmount = 0;
    float TimeAmount = 0;

    public static TimeStop Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start ()
    {
        TimeEffect = GameObject.Find("TimeEffect");
        TimeEffect.SetActive(false);
        GaugeNow = 100;
        Global.TheWorld = 1;
        TimeGauge = GameObject.Find("TimeBar").GetComponent<SimpleHealthBar>();
        StartCoroutine(Timer());
        InvokeRepeating("UpdateGauge", 0, 0.01f);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!Delay)
            {
                StartCoroutine(TimeChaging());
            }
        }
    }

    IEnumerator TimeChaging()
    {
        if (Global.TheWorld == 1)
        {
            if (GaugeNow >= 100)
            {
                Delay = true;
                TimeEffect.SetActive(true);
                while (Global.TheWorld > 0)
                {
                    TimeEffect.transform.localScale += new Vector3(0.5f+ 2.1f * Global.TheWorld, 0.5f + 2.1f * Global.TheWorld, 0);
                    Global.TheWorld -= 0.05f;
                    GaugeAmount = -0.2f * Global.TheWorld;
                    yield return new WaitForSeconds(0.02f);
                }
                GaugeAmount = -0.2f;
                Global.TheWorld = 0;
                Delay = false;
            }
        }
        else
        {
            if (Global.TheWorld == 0)
            {
                Delay = true;
                while (Global.TheWorld < 1)
                {
                    TimeEffect.transform.localScale -= new Vector3(0.5f + 2.1f * Global.TheWorld, 0.5f + 2.1f * Global.TheWorld, 0);
                    Global.TheWorld += 0.05f;
                    GaugeAmount = 0.04f * Global.TheWorld;
                    yield return new WaitForSeconds(0.02f);
                }
                TimeEffect.SetActive(false);
                Global.TheWorld = 1;
                GaugeAmount = 0.04f;
                Delay = false;
            }
        }
    }

    void UpdateGauge()
    {
        GaugeNow += GaugeAmount;
        if (GaugeNow <= 0)
        {
            GaugeNow = 0;
            StartCoroutine(TimeChaging());
        }

        if (GaugeNow >= 100)
        {
            GaugeNow = 100;
        }
        TimeGauge.UpdateBar(GaugeNow, GaugeMax);
    }

    IEnumerator Timer()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.1f);
            TimeAmount += 0.1f*Global.TheWorld * 60 * Time.deltaTime;
            Text.text = "Time:" + TimeAmount;
        }
    }
}
