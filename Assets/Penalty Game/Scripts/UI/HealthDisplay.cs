using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private List<Image> ImageList;

    public void DisableImage(int value)
    {
        ImageList[value].enabled = false;
    }

    public void EnableImage(int value)
    {
        ImageList[value].enabled = true;
    }

    public void EnableAll()
    {
        for (int i = 0; i < ImageList.Count; i++)
            EnableImage(i);
    }

    private void Start()
    {
        HealthHandler.Instance.OnChanged += DisableImage;
        HealthHandler.Instance.OnFullHealth += EnableAll;
    }

    private void OnDisable()
    {
        HealthHandler.Instance.OnChanged -= DisableImage;
        HealthHandler.Instance.OnFullHealth -= EnableAll;
    }
}
