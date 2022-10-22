using UnityEngine;
using TMPro;

public class GoalSectionCollision : MonoBehaviour, ICollision
{
    [SerializeField] private AudioPlayer Audio;
    [SerializeField] private int Points;
    [SerializeField] private TMP_Text Text;

    private const string _result = "Goal!";

    public void Hit()
    {
        BallMark.Instance.Delete();

        Audio.Play();
        LevelState.Instance.SetGoal();
        AddPoint();
        Disable();
        LevelSystem.Instance.StartDelay(_result);
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
