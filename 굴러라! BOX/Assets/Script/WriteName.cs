using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteName : MonoBehaviour {

    string str;
    public InputField inputField;
    public Text text;

    public void Show()
    {
        str = inputField.text;
        inputField.text = " ";
        Debug.Log(str);
    }
	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
