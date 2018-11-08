using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    string Stage = "Stage";
    int StageNumber = 0;
    Fade Fade;
    BoxAni BoxAni;

    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "ScriptLab")
        {
            Stage = "ScriptLab";
        }

        if (SceneManager.GetActiveScene().name == "Tutorial")
        {
            StageNumber = 0;
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
        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            StageNumber = 4;
        }


    }

    // Use this for initialization
    void Start ()
    {
        Fade = GameObject.Find("Black").GetComponent<Fade>();
        BoxAni = GameObject.Find("Box").GetComponent<BoxAni>();
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

    IEnumerator NextScene()
    {
        BoxAni.FLANI();
        yield return new WaitForSeconds(1.0f);
        Fade.FadeOut();
        yield return new WaitForSeconds(4.0f);
        Debug.Log("재시작");
        SceneManager.LoadScene(Stage + (StageNumber+1));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
            /* if(SceneManager.GetActiveScene().name == "Stage4")
             {
                 SceneManager.LoadScene("Ending");
             }
             */
            StartCoroutine(NextScene());
        }

    }
}
