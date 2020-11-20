using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip[] audioList;
    List<AudioSource> audioSource = new List<AudioSource>();

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        for(int i = 0; i < audioList.Length; i++)
        {
            audioSource.Add(new AudioSource());
            audioSource[i] = gameObject.AddComponent<AudioSource>();
            audioSource[i].clip = audioList[i];
        }
    }

    public void Sound(int sound)
    {
        audioSource[sound].Play();
    }
}
