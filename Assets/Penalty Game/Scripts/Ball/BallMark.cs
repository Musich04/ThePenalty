using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMark : MonoBehaviour
{
    public static BallMark Instance { get; private set; }
    public event System.Action<string> OnDelete;

    private const string _result = "Miss!";

    public BallCollision BallCollision => GetComponent<BallCollision>();
    public BallDirection BallDirection => GetComponent<BallDirection>();
    
    private void Awake()
    {
        Instance = this;

        BallDirection.OnDirect += T => DestroyDelay();
    }

    public void Delete()
    {
        Instance = null;
        BallDirection.OnDirect -= T => DestroyDelay();
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
        LevelState.Instance.SetMiss();
        LevelSystem.Instance.StartDelay(_result);
        Delete();
    }

    private void OnDestroy()
    {
        OnDelete = null;
    }
}
