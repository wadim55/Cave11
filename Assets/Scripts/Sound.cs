
using UnityEngine;

public class Sound : Item
{
    private static AudioClip[] clips;
    public AudioClip[] clipInspector;
    
    
    
    private AudioSource audio;

    private void Awake()
    {
        audio = gameObject.AddComponent<AudioSource>() as AudioSource;
    }
    private void Start()
    {
        clips = clipInspector;
        audio = GetComponent<AudioSource>();
    }

    public void PlaySound(int numberClip, float volume = 1, float pitch = 1)
    {
        audio.clip = clips[numberClip];
        audio.volume = volume;
        audio.pitch = pitch;
        audio.Play();
    }
    
}
