using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    string Stage = "Stage";


    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "ScriptLab")
        {
            Stage = "ScriptLab";
        }

        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            Stage = Stage + "1";
        }

        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            Stage = Stage + "2";
        }
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
        SceneManager.LoadScene(Stage);
    }

}
