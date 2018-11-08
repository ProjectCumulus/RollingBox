using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boxneighborhood : MonoBehaviour
{
    public GameObject A, B, C, D, E;
    float RotateAngle = 5f;
    public float MoveSpeed = 0.0125f;
    Rigidbody2D rb;
    int BoxRotation = 1;
    int Check = 1;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position += new Vector3(MoveSpeed, 0, 0);
        // this.transform.Rotate(new Vector3(0, 0, -RotateAngle));
        /*
         if (Check == 1 && BoxRotation == 1)
         {
             rb.freezeRotation = true;
             InvokeRepeating("BoxMove", 0, 0.001f);
         }*/

        transform.position += new Vector3(MoveSpeed, 0, 0);
        this.transform.Rotate(new Vector3(0, 0, -RotateAngle));//회전

        if (SceneManager.GetActiveScene().name == "Ending")
        {
            if (A.transform.position.x > 95)
            {
                A.transform.position = new Vector2(-35, transform.position.y);
            }

            if (B.transform.position.x > 97)
            {
                B.transform.position = new Vector2(-33, transform.position.y);
            }

            if (C.transform.position.x > 99)
            {
                C.transform.position = new Vector2(-31, transform.position.y);
            }

            if (D.transform.position.x > 101)
            {
                D.transform.position = new Vector2(-29, transform.position.y);
            }

            if (E.transform.position.x > 103)
            {
                E.transform.position = new Vector2(-27, transform.position.y);
            }
        }
    }
}
/* if (transform.position.x > 105)
 {
     transform.position = new Vector2(-35, transform.position.y);
 }
 */


/*void BoxMove()
{
    transform.position += new Vector3(MoveSpeed, 0, 0);
    this.transform.Rotate(new Vector3(0, 0, -RotateAngle));//회전
    BoxRotation++;
    if (BoxRotation > 50)
    {
        rb.freezeRotation = false;
        CancelInvoke("BoxMove");
        BoxRotation = 1;
    }
}
*/
