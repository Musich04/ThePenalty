using UnityEngine;

public class CrossbarCollision : MonoBehaviour, ICollision
{
    private const string _result = "Crossbar!";

    public void Hit()
    {
        Debug.Log("Crossbar");
    }

    public string Result()
    {
        return _result;
    }
}