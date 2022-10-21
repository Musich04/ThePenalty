using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactory : MonoBehaviour
{
    [SerializeField] private ScriptableBall SimpleBall;
   
    public void CreateBall()
    {
       Instantiate(SimpleBall.prefab);
    }
}
