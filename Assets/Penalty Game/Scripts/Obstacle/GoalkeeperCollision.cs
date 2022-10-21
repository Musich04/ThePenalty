using UnityEngine;

public class GoalkeeperCollision : MonoBehaviour, ICollision
{
    private const string _result = "Parry!";

    public void Hit()
    {
        // parry
    }

    public string Result()
    {
        return _result;
    }
}
