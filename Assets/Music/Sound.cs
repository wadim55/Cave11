using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public List<AudioClip> _clip;
    private AudioSource Audio => GetComponent<AudioSource>();

   
    public void PlaySound(AudioClip clip, float volume = 1, float pitch = 1)
    {
        Audio.clip = clip;
        Audio.volume = volume;
        Audio.pitch = pitch;
        Audio.Play();
    }
    
}
