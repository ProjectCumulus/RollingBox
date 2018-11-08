using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger_Start : MonoBehaviour {
    public GameObject Text1, Text2, Text3, Keys;
    // Use this for initialization
    void Start () {
        StartCoroutine(Test());
        Text1.gameObject.SetActive(false);
        Text2.gameObject.SetActive(false);
        Text3.gameObject.SetActive(false);
        Keys.gameObject.SetActive(false);
    }

    IEnumerator Test()
    {
        yield return new WaitForSeconds(1.0f);
        Text1.gameObject.SetActive(true);

        yield return new WaitForSeconds(2.5f);
        Text1.gameObject.SetActive(false);
        Text2.gameObject.SetActive(true);

        yield return new WaitForSeconds(2.5f);
        Text2.gameObject.SetActive(false);
        Text3.gameObject.SetActive(true);

        yield return new WaitForSeconds(1.0f);
        Keys.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
