using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{

    SpriteRenderer SPR;

    // Use this for initialization
    void Start ()
    {
        SPR = this.GetComponent<SpriteRenderer>();      
        FadeIn();
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void FadeIn()
    {
        StartCoroutine(AlphaDec());
    }

    public void FadeOut()
    {
        StartCoroutine(AlphaInc());
    }

    IEnumerator AlphaInc()
    {
        SPR.color = new Color(0, 0, 0, 1);
        while (SPR.color.a<255)
        {
            SPR.color += new Color(0, 0, 0, 60 * Time.deltaTime/255f);
            Debug.Log(SPR.color);
            yield return new WaitForSeconds(0.01f);
        }

    }

    IEnumerator AlphaDec()
    {
        while (SPR.color.a > 0)
        {
            SPR.color -= new Color(0, 0, 0, 60*Time.deltaTime/255f);
            Debug.Log(SPR.color);
            yield return new WaitForSeconds(0.01f);
        }
        SPR.color = new Color(0, 0, 0, 1);
    }
}
