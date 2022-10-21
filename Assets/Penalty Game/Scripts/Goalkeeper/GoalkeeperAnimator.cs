using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalkeeperAnimator : AnimatorHandler
{
    private const string _parameter = "jump_value";

    public void SetAnimation(int value)
    {
        SetIntParameter(_parameter, value);
    }

    public override void SetIdle()
    {
        SetAnimation(0);
    }
}
