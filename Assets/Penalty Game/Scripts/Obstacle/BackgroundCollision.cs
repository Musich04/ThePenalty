using UnityEngine;

public class BackgroundCollision : MonoBehaviour, ICollision
{
    private const string _result = "Miss!";

    public void Hit()
    {
        BallMark.Instance.Delete();
    }

    public string Result()
    {
        return _result;
    }
}
