using UnityEngine;

public class MousePoint
{
    private Vector3 _point;

    public void Init() => _point = Input.mousePosition;
    public Vector3 GetPoint() => _point;
}
