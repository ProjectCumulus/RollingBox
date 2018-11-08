using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroll : MonoBehaviour
{
    public GameObject target;

    public float StageFirstX = 15;
    public float StageLastX = 200;

    // Use this for initialization
    void Start ()
    {
	}

    // Update is called once per frame
    void LateUpdate()
    {

        if (target.transform.position.x < StageFirstX)
        {

            transform.position = new Vector3(StageFirstX, transform.position.y, transform.position.z);
        }
        else
        {
            if (target.transform.position.x > StageLastX)
            {

                transform.position = new Vector3(StageLastX, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
            }
        }

    }
}
