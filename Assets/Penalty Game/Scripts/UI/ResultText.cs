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

    private void GameOverText()
    {
        Change("Game Over");
    }

    private void OnEnable()
    {
        HealthHandler.Instance.OnGameOver += GameOverText;
    }

    private void OnDisable()
    {
        HealthHandler.Instance.OnGameOver -= GameOverText;
    }
}
