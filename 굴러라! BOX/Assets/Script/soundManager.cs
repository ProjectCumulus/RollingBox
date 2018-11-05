using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    AudioClip AudioClip;
    AudioSource AudioSource;
    //public static soundManager instance = null;

    void Awake()
    {
        AudioClip = GetComponent<AudioClip>();
        AudioSource = GetComponent<AudioSource>();
        /*
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        */
    }



    public void Play(AudioClip clip)
    {
        AudioSource.clip = clip;
        AudioSource.Play();

    }

    void Start()
    {
      
    }
     void Update()
    {

    }

}
