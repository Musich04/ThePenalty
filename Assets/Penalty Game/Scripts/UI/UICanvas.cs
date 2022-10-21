using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICanvas : MonoBehaviour
{
    public static UICanvas Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public void PlayAudio()
    {
        // play
    }
}
