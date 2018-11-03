using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    string Stage = "Stage";
    int StageNumber = 0;


    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "ScriptLab")
        {
            Stage = "ScriptLab";
        }

        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            StageNumber = 1;
        }

        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            StageNumber = 2;
        }

        if (SceneManager.GetActiveScene().name == "Stage3")
        {
            StageNumber = 3;
        }

       /* if (SceneManager.GetActiveScene().name == "Stage4")
        {
            StageNumber = 4;
        }
        */
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Gameover()
    {
        StartCoroutine(SceneRestart());
    }

    IEnumerator SceneRestart()
    {
        yield return new WaitForSeconds(2.0f);
        Debug.Log("재시작");
        SceneManager.LoadScene(Stage+StageNumber);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
           SceneManager.LoadScene(Stage+(StageNumber+1));
        }
    }
}
