using UnityEngine;

public class CrossbarCollision : MonoBehaviour, ICollision
{
    [SerializeField] private AudioPlayer Audio;

    private const string _result = "Crossbar!";

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