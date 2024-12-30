using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TweenAnim : MonoBehaviour
{

    public static TweenAnim Instance;
    void Start()
    {
        Instance = this;
        UnityEngine.Object.DontDestroyOnLoad(gameObject);
    }

    void Update()
    {

    }


    public void ScaleFrom(Transform target, Vector3 fromScale, float time)
    {
        Vector3 tmp = target.localScale;
        target.localScale = fromScale;
        target.DOScale(tmp, time)
            .SetEase(Ease.OutBack)
            .SetUpdate(true)
            .OnComplete(() =>
            {
                target.localScale = tmp;
            });
    }

    public void ScaleTo(Transform target, Vector3 toScale, float time)
    {
        target.DOScale(toScale, time)
            .SetEase(Ease.OutBack)
            .SetUpdate(true);
    }


    public void ShowPopUpTween(Transform target)
    {
        target.gameObject.SetActive(true);
        target.localScale = Vector3.zero;
        target.DOScale(1f, 0.4f)
            .SetEase(Ease.OutBack)
            .SetUpdate(true)
            .OnComplete(() =>
            {
            }); ;
    }

    public void HidePopUpTween(Transform target)
    {
        target.DOScale(0f, 0.1f)
            .SetEase(Ease.Linear)
            .SetUpdate(true)
            .OnComplete(() =>
            {
                target.gameObject.SetActive(false);
            });
    }


    public void ShowPanel(object target)
    {
        if (target is GameObject gameObject)
        {
            CanvasGroup canvasGroup = gameObject.GetComponent<CanvasGroup>();
            gameObject.SetActive(true);
            if (canvasGroup != null)
            {
                canvasGroup.alpha = 0;
                canvasGroup.DOFade(1f, 0.2f).SetUpdate(true)
                    .OnComplete(() =>
                    {
                        canvasGroup.interactable = true;
                        canvasGroup.blocksRaycasts = true;
                    });
            }
        }
    }

    public void HidePanel(object target)
    {
        if (target is GameObject gameObject)
        {
            CanvasGroup canvasGroup = gameObject.GetComponent<CanvasGroup>();
            if (canvasGroup != null)
            {
                canvasGroup.DOFade(0f, 0.2f).SetUpdate(true)
                    .OnComplete(() =>
                    {
                        gameObject.SetActive(false);
                    });
            }
        }
    }

    public void MoveTo(Transform targetObj, float time, Vector3 distance)
    {
        targetObj.DOKill();
        targetObj.DOMove(targetObj.position + distance, time)
                   .SetEase(Ease.OutBack)
                   .SetUpdate(true)
                   .OnComplete(() =>
                   {
                       targetObj.transform.position -= distance;
                   });
    }

    public void MoveFrom(Transform targetObj, float time, Vector3 distance)
    {
        targetObj.DOKill();

        Vector3 tmp = targetObj.position;
        targetObj.position = targetObj.position + distance;
        targetObj.DOMove(tmp, time)
            .SetEase(Ease.OutBack)
            .SetUpdate(true)
                   .OnComplete(() =>
                   {
                       targetObj.transform.position = tmp;
                   });
    }


    //Move vao scene
    public void MoveFromLeftToScreen(Transform targetObj)
    {
        MoveFrom(targetObj, 0.8f, new Vector3(-300, 0, 0));
    }
    public void MoveFromRightToScreen(Transform targetObj)
    {
        MoveFrom(targetObj, 0.8f, new Vector3(300, 0, 0));
    }
    public void MoveFromBottomToScreen(Transform targetObj)
    {
        MoveFrom(targetObj, 0.8f, new Vector3(0, -300, 0));
    }
    public void MoveFromTopToScreen(Transform targetObj)
    {
        MoveFrom(targetObj, 0.8f, new Vector3(0, 300, 0));
    }

    //Move ra ngoai scene
    public void MoveToLeftFromScreen(Transform targetObj)
    {
        MoveTo(targetObj, 0.3f, new Vector3(-300, 0, 0));
    }
    public void MoveToRightFromScreen(Transform targetObj)
    {
        MoveTo(targetObj, 0.3f, new Vector3(300, 0, 0));
    }
    public void MoveToBottomFromScreen(Transform targetObj)
    {
        MoveTo(targetObj, 0.3f, new Vector3(0, -300, 0));
    }
    public void MoveToTopFromScreen(Transform targetObj)
    {
        MoveTo(targetObj, 0.3f, new Vector3(0, 300, 0));
    }
}
