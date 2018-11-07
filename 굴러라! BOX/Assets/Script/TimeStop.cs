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
    public GameObject CAR;
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
        CAR.SetActive(false);
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
                CAR.SetActive(true);
                while (Global.TheWorld > 0)
                {
                    CAR.transform.localScale += new Vector3(1, 1,0);
                    yield return new WaitForSeconds(0.02f);
                    Global.TheWorld -= 0.05f;
                    GaugeAmount = -0.2f * Global.TheWorld;
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
                    CAR.transform.localScale -= new Vector3(1, 1, 0);
                    yield return new WaitForSeconds(0.02f);
                    Global.TheWorld += 0.05f;
                    GaugeAmount = 0.04f* Global.TheWorld;
                }
                CAR.SetActive(false);
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
