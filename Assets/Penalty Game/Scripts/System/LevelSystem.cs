using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    [SerializeField] private BallFactory BallFactory;
    [SerializeField] private List<GoalSectionCollision> SectionList;
    [SerializeField] private TextInstance HitResult;

    private void Start()
    {
        StartLevel();
    }

    private void StartLevel()
    {
        CreateBall();
        EnableSections();
        HitResult.Disable();
    }

    private void CreateBall()
    {
        if (BallMark.Instance != null)
            BallMark.Instance.Delete();

        BallFactory.CreateBall();

        BallMark.Instance.BallCollision.OnCollision += StartDelay;
        BallMark.Instance.OnDestroy += StartDelay;
    }

    private void StartDelay(string text)
    {
        HitResult.Change(text);
        StartCoroutine(StartCoroutine(2f));
    }

    private IEnumerator StartCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        StartLevel();
    }

    private void EnableSections()
    {
        foreach (var section in SectionList)
            section.Enable();
    }
}
