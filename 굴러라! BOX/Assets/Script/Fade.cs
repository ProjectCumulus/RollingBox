using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Fade : MonoBehaviour
{

    Image Image;
    public GameObject FCanvas;
    Canvas Canvas;
    // Use this for initialization
    void Start ()
    {
        Image = this.GetComponent<Image>();
        Canvas = FCanvas.GetComponent<Canvas>();
        FadeIn();
    }

    private void OnLevelWasLoaded(int level)
    {
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
        Canvas.sortingOrder = 1;
        while (Image.color.a<1)
        {
            Image.color+=new Color(0, 0, 0, 2*60 * Time.deltaTime / 255f);
            Debug.Log(Image.color);
            yield return new WaitForFixedUpdate();
        }
        Image.color = new Color(0, 0, 0, 1);
    }

    IEnumerator AlphaDec()
    {
        Canvas.sortingOrder = 1;
        Image.color = new Color(0, 0, 0, 1);
        while (Image.color.a > 0)
        {
            Image.color -= new Color(0, 0, 0, 2 * 60 * Time.deltaTime / 255f);
            Debug.Log(Image.color);
            yield return new WaitForFixedUpdate();
        }
        Canvas.sortingOrder = -1;

    }
}
