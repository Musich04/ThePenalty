using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioBall : AudioPlayer
{
    private void OnEnable()
    {
        GetComponent<BallDirection>().OnDirect += T => Play();
    }

    private void OnDisable()
    {
        GetComponent<BallDirection>().OnDirect -= T => Play();
    }
}
