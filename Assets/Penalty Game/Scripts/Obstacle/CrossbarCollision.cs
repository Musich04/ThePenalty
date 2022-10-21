using UnityEngine;

public class CrossbarCollision : MonoBehaviour, ICollision
{
    private const string _result = "Crossbar!";

    public void Hit()
    {
        LevelState.Instance.SetMiss();
        LevelSystem.Instance.StartDelay(_result);
    }

    public string Result()
    {
        return _result;
    }
}