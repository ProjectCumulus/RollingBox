using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeCanvas : MonoBehaviour
{
    public static FadeCanvas Instance;
    Canvas Canvas;
    // Use this for initialization
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    void Start ()
    {
        Canvas = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SortOrderNegetive()
    {
        Canvas.sortingOrder = -1;
    }

    public void SortOrderPositive()
    {
        Canvas.sortingOrder = 1;
    }
}
