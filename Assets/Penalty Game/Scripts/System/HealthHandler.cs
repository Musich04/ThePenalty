using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    public static HealthHandler Instance { get; private set; }
    public event System.Action<int> OnChanged;
    public event System.Action OnGameOver;
    public event System.Action OnFullHealth;

    private int _totalHealth = 3;
    private int _currentHealth;

    private void Awake()
    {
        Instance = this;
        _currentHealth = _totalHealth;
    }

    public void MinusHealth()
    {
        if (_currentHealth > 0)
        {
            OnChanged?.Invoke(_totalHealth - _currentHealth);
            _currentHealth--;
        }

        CheckDeath();
    }

    public void SetFullHealth()
    {
        _currentHealth = _totalHealth;
        OnFullHealth?.Invoke();
    }

    private void CheckDeath()
    {
        if (_currentHealth == 0)
            OnGameOver?.Invoke();
    }
}
