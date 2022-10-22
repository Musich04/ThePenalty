using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAudioResult : MonoBehaviour
{
    [SerializeField] private AudioPlayer[] Audio;

    public void PlayGoal()
    {
        Audio[0].Play();
    }

    public void PlayMiss()
    {
        Audio[1].Play();
    }
}
