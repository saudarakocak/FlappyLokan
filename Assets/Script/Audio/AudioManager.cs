using UnityEngine.Audio;
using UnityEngine;
using System;

[System.Serializable]
public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;



    void Awake()
    {
        foreach(Sound x in sounds)
        {
            x.source = gameObject.AddComponent<AudioSource>();
            x.source.clip = x.clip;
            x.source.volume = x.volume;
            x.source.pitch = x.pitch;
            x.source.loop = x.loop;
        }    
    }

    public void Play(String name)
    {
        Sound x = Array.Find(sounds, Sound => Sound.Name == name);
        x.source.Play();
    }
    public void stop(String name)
    {
        Sound x = Array.Find(sounds, Sound => Sound.Name == name);
        x.source.Stop();
    }
}
