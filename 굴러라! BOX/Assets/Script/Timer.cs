using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text TimerText;
    public string additionalText = string.Empty;
    // Use this for initialization
    void Start ()
    {
        DontDestroyOnLoad(this);
        StartCoroutine(UpdateTime());
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    IEnumerator UpdateTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            TimerText.text = additionalText + Time.time;
        }
    }
}
