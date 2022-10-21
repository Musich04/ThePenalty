using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultText : TextInstance, IActivity
{
    public override void Change(string text)
    {
        Text.text = text;
        Enable();
    }
}
