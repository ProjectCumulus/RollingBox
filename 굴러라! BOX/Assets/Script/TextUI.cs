using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextNUM
{
    public static int TriggerNum = 0;
}


public class TextUI : MonoBehaviour
{
    public Text TTT;
    TextNUM TextNUM;
    string[] Tutorial = new string[20];

	// Use this for initialization
	void Start ()
    {
        Tutorial[0] = "1번 메세지";
        Tutorial[1] = "2번 메세지";
        Tutorial[2] = "3번 메세지";
        Tutorial[3] = "4번 메세지";
        Tutorial[4] = "5번 메세지";
        Tutorial[5] = "6번 메세지";
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TTT.text = Tutorial[TextNUM.TriggerNum];
            TextNUM.TriggerNum++;
            this.gameObject.SetActive(false);
        }
    }
}
