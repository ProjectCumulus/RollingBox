using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void GameStart()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Ranking()
    {
        SceneManager.LoadScene("Ranking");
    }

    public void TimeStop()
    {
        if(Time.timeScale==1)
        {
            StartCoroutine(TheWorld(true));
        }
        else
        {
            StartCoroutine(TheWorld(false));
        }
    }

    IEnumerator TheWorld(bool stand)
    {
        if (stand)
        {
            for (int i = 25; i > -1; i--)
            {
                yield return new WaitForSecondsRealtime(0.04f);
                Time.timeScale = 0.04f * i;
            }
        }
        else
        {
            for (int i = 0; i < 26; i++)
            {
                yield return new WaitForSecondsRealtime(0.04f);
                Time.timeScale = 0.04f * i;
            }
        }
        Debug.Log(Time.timeScale);

    }

}
