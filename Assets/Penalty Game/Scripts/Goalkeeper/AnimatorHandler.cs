using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnimatorHandler : MonoBehaviour
{
    private Animator _animator => GetComponent<Animator>();

    protected void SetIntParameter(string name, int value)
    {
        _animator.SetInteger(name, value);
    }

    public abstract void SetIdle();
}
