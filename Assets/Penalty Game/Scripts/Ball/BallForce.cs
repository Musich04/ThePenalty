using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    [Range(0f, 1f)]
    [SerializeField] private float StrengthHit;

    private Rigidbody _rigidbody;
    private BallDirection _ballCollider;

    private void SetForce(Vector3 vector)
    {
        _rigidbody.AddForce(vector * StrengthHit, ForceMode.Force);
    }

    private void OnEnable()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _ballCollider = GetComponent<BallDirection>();

        _ballCollider.OnDirect += SetForce;
    }

    private void OnDisable()
    {
        _ballCollider.OnDirect -= SetForce;
    }
}
