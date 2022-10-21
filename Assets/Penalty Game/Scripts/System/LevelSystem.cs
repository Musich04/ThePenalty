using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public static LevelSystem Instance { get; private set; }
    public event System.Action OnStart;

    [SerializeField] private List<GoalSectionCollision> SectionList;
    [SerializeField] private TextInstance Result;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        HealthHandler.Instance.OnGameOver += NewGame;

        NewGame();
    }

    private void NewGame()
    {
        StartLevel();
        PointHandler.Instance.RemovePoints();
        HealthHandler.Instance.SetFullHealth();
    }

    private void StartLevel()
    {
        if (BallMark.Instance != null)
            BallMark.Instance.Delete();

        OnStart?.Invoke();

        foreach (var section in SectionList)
            section.Enable();
    }

    public void StartDelay(string text)
    {
        Result.Change(text);
        StartCoroutine(StartCoroutine(2f));
    }

    private IEnumerator StartCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        CheckResult();
        StartLevel();
    }

    private void CheckResult()
    {
        if (LevelState.Instance.IsGoal == false)
            HealthHandler.Instance.MinusHealth();
    }

    private void OnDisable()
    {
        HealthHandler.Instance.OnGameOver -= NewGame;
    }
}
