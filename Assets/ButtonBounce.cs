using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ButtonBounce : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private float bounceScale = 1.2f;
    [SerializeField] private float duration = 0.5f;

    private void Start()
    {
        if (button == null)
            button = GetComponent<Button>();

        transform.DOScale(bounceScale, duration)
                .SetEase(Ease.InOutSine)
                .SetLoops(-1, LoopType.Yoyo);
    }
}
