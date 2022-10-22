using UnityEngine;

public class GoalkeeperCollision : MonoBehaviour, ICollision
{
    [SerializeField] private AudioPlayer Audio;

    private const string _result = "Parry!";

    public void Hit()
    {
        Audio.Play();
        LevelState.Instance.SetMiss();
        LevelSystem.Instance.StartDelay(_result);
    }

    public string Result()
    {
        return _result;
    }
}
