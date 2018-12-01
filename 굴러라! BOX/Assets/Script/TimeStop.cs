﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class Global
{
    public static float TheWorld = 1;
    public static float PresentTime = 600;
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
    bool TimerOn = false;
    float TimeIncrease = 0.1f;

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
        Global.PresentTime = 600;
        TimerOn = false;
        TimeEffect = GameObject.Find("TimeEffect");
        TimeEffect.GetComponent<SpriteRenderer>().enabled = false;
        GaugeNow = 100;
        Global.TheWorld = 1;
        TimeGauge = GameObject.Find("TimeBar").GetComponent<SimpleHealthBar>();
        StartCoroutine(Timer());
        InvokeRepeating("UpdateGauge", 0, 0.01f);
    }

    private void OnLevelWasLoaded(int level)
    {
        if (SceneManager.GetActiveScene().name != "Tutorial")
        {
            TimerOn = true;
        }
        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            TimerOn = true;
            Destroy(GameObject.Find("Fancy Bar"));
            Destroy(GameObject.Find("Pause"));
            Destroy(GameObject.Find("Home"));
        }
        if (SceneManager.GetActiveScene().name == "Stage4-2")
        {
            TimerOn = false;
            Destroy(this.gameObject);
        }
        if (SceneManager.GetActiveScene().name == "Ending")
        {
            Destroy(this.gameObject);
        }
        TimeEffect = GameObject.Find("TimeEffect");
        TimeEffect.GetComponent<SpriteRenderer>().enabled = false;

        StopCoroutine(TimeChaging());
        Delay = false;
        GaugeAmount = 0.04f;
        Global.TheWorld = 1;
        GaugeNow = 100;
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
                TimeEffect.GetComponent<SpriteRenderer>().enabled = true;
                while (Global.TheWorld > 0)
                {
                    TimeEffect.transform.localScale += new Vector3(1f+ 3f * Global.TheWorld, 1f + 3f * Global.TheWorld, 0);
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
                    TimeEffect.transform.localScale -= new Vector3(1f + 3f * Global.TheWorld, 1f + 3f * Global.TheWorld, 0);
                    Global.TheWorld += 0.05f;
                    GaugeAmount = 0.04f * Global.TheWorld;
                    yield return new WaitForSeconds(0.02f);
                }
                TimeEffect.GetComponent<SpriteRenderer>().enabled = false;
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
            if (TimerOn)
            {
                Global.PresentTime -= TimeIncrease * Global.TheWorld * 60 * Time.deltaTime;
            }
            if(Global.PresentTime<0)
            {
                Global.PresentTime = 0;
                SceneManager.LoadScene("Stage4-2");
            }
            Text.text = "Time:" + Global.PresentTime.ToString("##0.0");//string.Format("{0:###. 00}", TimeAmount);

        }
    }

    IEnumerator TimerEnd()
    {
        TimerOn = false;
        for(float i=0.1f; i>0.2; i+=0.01f)
        {
            yield return new WaitForSeconds(i);
            Global.PresentTime -= 0.1f * 60 * Time.deltaTime;
        }


        TimeIncrease = 0;
        Text.text = "Time:" + Global.PresentTime.ToString("##0.0");
    }

    public void Ending()
    {
        StartCoroutine(TimerEnd());
    }
}
