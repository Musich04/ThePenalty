using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperState : MonoBehaviour
{
    private GoalkeeperAnimator _animator => GetComponent<GoalkeeperAnimator>();

    public void Jump()
    {
        IntegerGenerator generator = new IntegerGenerator(1, 5);
        int value = generator.Generate();

        _animator.SetAnimation(value);
    }

    public void Init()
    {
        _animator.SetIdle();

        BallMark.Instance.BallDirection.OnDirect += T => Jump();
    }

    private void Start()
    {
        LevelSystem.Instance.OnStart += Init;
    }

    private void OnDisable()
    {
        LevelSystem.Instance.OnStart -= Init;
    }
}
