using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAni : MonoBehaviour
{
    public Sprite[] SPArray;
    int PresentSprite = 0;
    SpriteRenderer SR;
    Sprite Sprite;
    // Use this for initialization
    void Start()
    {
        SR = this.GetComponent<SpriteRenderer>();
        Sprite = this.GetComponent<Sprite>();
        InvokeRepeating("Ani", 0, 0.05f);
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    void Ani()
    {
        Debug.Log(PresentSprite);
        Debug.Log(SR.sprite.name);
        SR.sprite = SPArray[PresentSprite];
        if (PresentSprite == 35)
        {
            Debug.Log("범위초과");
            PresentSprite = 0;
        }
        else
        {
            PresentSprite++;
        }
    }
}
