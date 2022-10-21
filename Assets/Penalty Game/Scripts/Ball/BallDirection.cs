using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDirection : MonoBehaviour
{
    public event System.Action<Vector3> OnDirect;

    private BallInput _ballCollider;

    private MousePoint _pointDown = new MousePoint();
    private MousePoint _pointUp = new MousePoint();

    private void SetDirection()
    {
        _pointUp.Init();
        OnDirect?.Invoke(GetVector());
    }

    private Vector3 GetVector()
    {
        Vector3 vector = _pointUp.GetPoint() - _pointDown.GetPoint();
        return Convert(vector);
    }

    private Vector3 Convert(Vector3 mouseVector)
    {
        mouseVector.z = -mouseVector.x;
        mouseVector.x = mouseVector.magnitude;
        return mouseVector;
    }

    private void OnEnable()
    {
        _ballCollider = GetComponent<BallInput>();

        _ballCollider.OnDown += _pointDown.Init;
        _ballCollider.OnUp += SetDirection;
    }

    private void OnDisable()
    {
        _ballCollider.OnDown -= _pointDown.Init;
        _ballCollider.OnUp -= SetDirection;
    }
}
