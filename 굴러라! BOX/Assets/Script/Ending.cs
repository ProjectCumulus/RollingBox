using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour {

    
    
    string Stage = "Stage";
    int StageNumber = 0;

    // Use this for initialization
    void Start () {
        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            StageNumber = 4;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //if (SceneManager.GetActiveScene().name == "Stage4")
            {
                SceneManager.LoadScene("Ending");
            }
        }
          
    }
}
