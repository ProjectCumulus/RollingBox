using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Global
{
    public static float TheWorld = 1;
}

public class TimeStop : MonoBehaviour
{
    SimpleHealthBar TimeGauge;
    bool Delay = false;
    float GaugeMax = 100;
    float GaugeNow = 100;
    float GaugeAmount = 0;

	// Use this for initialization
	void Start ()
    {
		TimeGauge= GameObject.Find("TimeBar").GetComponent<SimpleHealthBar>();
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
        Debug.Log(Delay);
    }

    IEnumerator TimeChaging()
    {
        if (Global.TheWorld == 1)
        {
            if (GaugeNow >= 100)
            {
                Delay = true;

                while (Global.TheWorld > 0)
                {
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
                    yield return new WaitForSeconds(0.02f);
                    Global.TheWorld += 0.05f;
                    GaugeAmount = 0.04f* Global.TheWorld;
                }
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
}
