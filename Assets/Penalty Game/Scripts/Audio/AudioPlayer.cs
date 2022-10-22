using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioSource _audio => GetComponent<AudioSource>();

    public void Play()
    {
        _audio.Play();
    }

    public void Stop()
    {
        _audio?.Stop();
    }
}
