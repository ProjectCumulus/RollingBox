using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodicTrap : MonoBehaviour {

    public float ActiveTime = 1;
    public float CycleTime = 1;

    private SpriteRenderer Sprite;
    private BoxCollider2D Collider;

	// Use this for initialization
	void Start ()
    {
        Sprite = GetComponent<SpriteRenderer>();
        Collider = GetComponent<BoxCollider2D>();
        StartCoroutine(Active());
    }
	
	// Update is called once per frame
	void Update ()
    {

	}

    IEnumerator Active()
    {
        while (true)
        {
            Sprite.enabled = true;
            Collider.enabled = true;
            yield return new WaitForSeconds(ActiveTime);
            Sprite.enabled = false;
            Collider.enabled = false;
            yield return new WaitForSeconds(CycleTime);
        }
    }
}
