using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections;
//using System.Collections;

public class AudioManager : MonoBehaviour
{


    public Sound[] sounds;

    // Use this for initialization
    void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }

    }

    // Start the audio
    public void Play(string name, bool loop)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.volume = s.volume;
        s.source.pitch = s.pitch;
        s.source.Play();
        s.source.loop = loop;
    }

    // Stop the audio
    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }


    // Stop the audio by time
    public void Falloff_Stop(string name, float magnitude)
    {
        StartCoroutine(Falloff_Begin(name, magnitude));
    }

    // Make it look like a Update function
    public IEnumerator Falloff_Begin(string name, float magnitude)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        while (s.source.volume > 0)
        {
            s.source.volume -= magnitude;
            Debug.Log("Volume: "+ s.source.volume);

            yield return null;
        }
    }
}
