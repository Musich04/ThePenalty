using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInput : MonoBehaviour, IActivity
{
    public event System.Action OnDown;
    public event System.Action OnUp;

    private bool _isEnabled = true;

    private void OnMouseDown()
    {
        if (_isEnabled == true)
            OnDown?.Invoke();
    }

    private void OnMouseUp()
    {
        if (_isEnabled == true)
        {
            OnUp?.Invoke();
            Disable();
        }
    }

    public void Enable() => _isEnabled = true;
    public void Disable() => _isEnabled = false;
}
