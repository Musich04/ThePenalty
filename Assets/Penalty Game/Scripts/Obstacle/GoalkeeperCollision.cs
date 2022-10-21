using UnityEngine;

public class GoalkeeperCollision : MonoBehaviour, ICollision
{
    private const string _result = "Parry!";

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
