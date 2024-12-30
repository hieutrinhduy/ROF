using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelNotify : MonoBehaviour
{
    [SerializeField] private Transform notify;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        TweenAnim.Instance.MoveFromTopToScreen(notify);
        yield return new WaitForSeconds(1f);
        TweenAnim.Instance.MoveToTopFromScreen(notify);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
