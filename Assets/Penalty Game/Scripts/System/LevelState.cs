using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelState : MonoBehaviour
{
    public static LevelState Instance { get; private set; }
    public bool IsGoal { get; private set; }

    private void Awake()
    {
        Instance = this;
        IsGoal = false;
    }

    public void SetGoal()
    {
        IsGoal = true;
    }

    public void SetMiss()
    {
        IsGoal = false;
    }

    private void OnEnable()
    {
        HealthHandler.Instance.OnGameOver += SetMiss;
    }

    private void OnDisable()
    {
        HealthHandler.Instance.OnGameOver -= SetMiss;
    }
}
