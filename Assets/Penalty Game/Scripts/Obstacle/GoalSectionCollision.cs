using UnityEngine;
using TMPro;

public class GoalSectionCollision : MonoBehaviour, ICollision
{
    [SerializeField] private int Points;
    [SerializeField] private TMP_Text Text;

    private const string _result = "Goal!";

    public void Hit()
    {
        AddPoint();
        BallMark.Instance.Delete();
        Disable();
    }

    public string Result()
    {
        return _result;
    }

    private void AddPoint()
    {
        PointHandler.Instance.PlusPoint(Points);
    }

    public void Enable()
    {
        GetComponent<Collider>().enabled = true;
        GetComponent<MeshRenderer>().enabled = true;

        Text.gameObject.SetActive(true);
    }

    public void Disable()
    {
        GetComponent<Collider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        Text.gameObject.SetActive(false);
    }

    
}
