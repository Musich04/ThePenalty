using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointHandler : MonoBehaviour
{
    public static PointHandler Instance { get; private set; }
    public event System.Action<int> OnChanged;

    private int _points = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void PlusPoint(int value)
    {
        _points += value;
        OnChanged?.Invoke(_points);
    }

    public void RemovePoints()
    {
        _points = 0;
        OnChanged?.Invoke(_points);
    }

    public int GetPoints() => _points;
}
