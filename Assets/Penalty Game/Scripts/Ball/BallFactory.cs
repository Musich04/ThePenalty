using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactory : MonoBehaviour
{
    [SerializeField] private ScriptableBall SimpleBall;
    private BallDirection _ballCollider;

    private void Awake()
    {
        CreateBall();
    }

    public void CreateBall()
    {
       GameObject ball = Instantiate(SimpleBall.prefab);
        _ballCollider = ball.GetComponent<BallDirection>();

        // _ballCollider.OnDirect += 
    }
}
