
using System;
using UnityEngine;

public class Sound : MonoBehaviour
{
    private AudioSource audio;

    private void Awake()
    {
        audio = gameObject.AddComponent<AudioSource>() as AudioSource;
    }

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlaySound(int numberClip, float volume = 1, float pitch = 1)
    {
        audio.clip = LibrarySound.clip[numberClip];
        audio.volume = volume;
        audio.pitch = pitch;
        audio.Play();
    }
    
}
