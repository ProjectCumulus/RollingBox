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
        SceneManager.LoadScene("Tutorial");
    }

    public void Ranking()
    {
        SceneManager.LoadScene("Ranking");
    }

    public void Skip()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void Pause()
    {
        if(Time.timeScale==1)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void ReturnMain()
    {

        Debug.Log("홈");
        SceneManager.LoadScene("MainScreen");
        Destroy(this.gameObject);
    }

}
