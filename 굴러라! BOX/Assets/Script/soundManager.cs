using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public AudioClip soundExplosion; 
    AudioSource myAudio; 
    public static soundManager instance;
    void Awake() 
    {
        if (soundManager.instance == null) //incetance가 비어있는지 검사합니다.
        {
            soundManager.instance = this; //자기자신을 담습니다.
        }
    }
    void Start()
    {
        myAudio = this.gameObject.GetComponent<AudioSource>(); 
    }
    public void PlaySound()
    {
        myAudio.PlayOneShot(soundExplosion); 
    }
    void Update()
    {

    }
}
