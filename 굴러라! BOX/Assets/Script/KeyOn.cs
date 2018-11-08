using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyOn : MonoBehaviour {
    Image key;

    // Use this for initialization
    void Start()
    {
        key = this.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        key.color += new Color(0, 0, 0, 2 * 60 * Time.deltaTime / 50f);
    }
}

