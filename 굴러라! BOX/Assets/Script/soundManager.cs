using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource efxSource1;
    public AudioSource efxSource2;
    public AudioSource efxSource3;

    public float lowPitchRange = 0.95f; //  사운드 크기를 위 아래 5%씩
    public float highPitchRange = 1.05f; // 변화를 줌

    public static SoundManager instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }



    public void PlaySingle1(AudioClip clip)
    {
        efxSource1.clip = clip;
        efxSource1.Play();
    }
    public void PlaySingle2(AudioClip clip)
    {
        efxSource2.clip = clip;
        efxSource2.Play();
    }

    public void PlaySingle3(AudioClip clip)
    {
        efxSource3.clip = clip;
        efxSource3.Play();
    }

    void Start()
    {
      
    }
     void Update()
    {

    }

}
