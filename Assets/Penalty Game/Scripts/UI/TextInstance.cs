using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class TextInstance : MonoBehaviour, IActivity
{
    [SerializeField] protected TMP_Text Text;

    public abstract void Change(string text);

    public void Disable()
    {
        Text.gameObject.SetActive(false);
    }

    public void Enable()
    {
        Text.gameObject.SetActive(true);
    }
}
