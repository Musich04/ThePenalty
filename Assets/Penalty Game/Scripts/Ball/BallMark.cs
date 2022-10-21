using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMark : MonoBehaviour
{
    public static BallMark Instance { get; private set; }
    public event System.Action<string> OnDestroy;

    private const string _result = "Miss!";

    public BallCollision BallCollision => GetComponent<BallCollision>();
    
    private void Awake()
    {
        Instance = this;

        GetComponent<BallDirection>().OnDirect += T => DestroyDelay();
    }

    public void Delete()
    {
        Instance = null;
        GetComponent<BallDirection>().OnDirect -= T => DestroyDelay();
        StopAllCoroutines();
        Destroy(gameObject);
    }

    private void DestroyDelay()
    {
        StartCoroutine(DestroyCoroutine(5f));
    }

    private IEnumerator DestroyCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        OnDestroy?.Invoke(_result);
        OnDestroy = null;
        Delete();
    }
}
