using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPUI : MonoBehaviour
{
    public Image FA;
    BoxHP boxHP;
    public float hp;
    // Use this for initialization
    void Start()
    {
        boxHP = GameObject.Find("Box").GetComponent<BoxHP>();
    }

    // Update is called once per frame
    void Update ()
    {
        hp = boxHP.HP;
        FA.fillAmount = hp/100f;
	}
}