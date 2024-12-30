using UnityEngine;
using DG.Tweening;
using System.Collections;

public class NotifyRange : MonoBehaviour
{
    [SerializeField] private CanvasGroup group;
    [SerializeField] private float fadeDuration = 1f;
    [SerializeField] private float delayDuration = 1f;
    public bool notifyOnStart;
    private Collider collider;
    private void Awake()
    {
        if (notifyOnStart)
        {
            collider = GetComponent<Collider>();
            collider.enabled = false;
        }
    }

    private IEnumerator Start()
    {
        if (notifyOnStart)
        {
            yield return new WaitForSeconds(0.6f);
            Notify();
        }
    }

    private void Notify()
    {
        Sequence sequence = DOTween.Sequence();

        sequence
            .Append(group.DOFade(1f, fadeDuration))
            .AppendInterval(delayDuration)            
            .Append(group.DOFade(0f, fadeDuration))   
            .AppendInterval(delayDuration)            
            .OnComplete(() =>
            {
                Destroy(gameObject);
            });
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Notify();
        }
    }
}
