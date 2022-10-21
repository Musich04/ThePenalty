using UnityEngine;

public abstract class UIButton : MonoBehaviour
{

    public virtual void Press()
    {
        UICanvas.Instance.PlayAudio();
    }
}
