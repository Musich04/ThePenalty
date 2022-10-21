using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public event System.Action<string> OnCollision;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ICollision obstacle) == true)
        {
            OnCollision?.Invoke(obstacle.Result());
            OnCollision = null;
            
            obstacle.Hit();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out ICollision obstacle) == true)
        {
            obstacle.Hit();

            OnCollision?.Invoke(obstacle.Result());
            OnCollision = null;
        }
    }
}
