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

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            StartCoroutine(TimeChaing());
        }
    }

    IEnumerator TimeChaing()
    {
        if (Global.TheWorld == 1)
        {
            while (Global.TheWorld > 0)
            {
                yield return new WaitForSecondsRealtime(0.02f);
                Global.TheWorld -= 0.05f;
            }
            Global.TheWorld = 0;
        }
        else
        {
            while (Global.TheWorld < 1)
            {
                yield return new WaitForSecondsRealtime(0.02f);
                Global.TheWorld += 0.05f;
            }
            Global.TheWorld = 1;
        }
    }
}
