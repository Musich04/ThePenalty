using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Ball", fileName = "Ball")]
public class ScriptableBall : ScriptableObject
{
    [SerializeField] private GameObject Prefab;

    public GameObject prefab => Prefab;
}
