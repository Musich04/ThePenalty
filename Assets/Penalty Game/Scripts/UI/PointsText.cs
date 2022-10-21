using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsText : TextInstance
{
    private void SetValue(int value)
    {
        Change(value.ToString());
    }

    public override void Change(string text)
    {
        Text.text = text.ToString();
    }

    private void Start()
    {
        PointHandler.Instance.OnChanged += SetValue;
    }

    private void OnDisable()
    {
        PointHandler.Instance.OnChanged -= SetValue;
    }
}
