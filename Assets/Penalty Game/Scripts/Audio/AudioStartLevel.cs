using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioStartLevel : AudioPlayer
{
    private void Start()
    {
        LevelSystem.Instance.OnStart += Play;
    }

    private void OnDisable()
    {
        LevelSystem.Instance.OnStart -= Play;
    }
}
