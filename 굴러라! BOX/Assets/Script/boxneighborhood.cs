using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxneighborhood : MonoBehaviour {
    float RotateAngle = 3.6f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(Time.deltaTime * 60 * 0.075f, 0, 0);
        this.transform.Rotate(new Vector3(0, 0, -RotateAngle));//회전
    }
}
