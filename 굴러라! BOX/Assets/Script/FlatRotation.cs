using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatRotation : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("FlatRotate", 0, 1.0f);
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    void FlatRotate()
    {
        if (Global.TheWorld > 0)
        {
            this.transform.Rotate(new Vector3(0, 0, 90));//회전
        }
    }
}
