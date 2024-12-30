using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausePanel : MonoBehaviour
{
    [SerializeField] private Button resumeBtn;
    [SerializeField] private Button settingBtn;
    [SerializeField] private Button homeBtn;

    [SerializeField] private GameObject settingPanel;
    private void Start()
    {
        resumeBtn.onClick.AddListener(delegate
        {
            Time.timeScale = 1;
            TweenAnim.Instance.HidePopUpTween(gameObject.transform);
            //gameObject.SetActive(false);
        });

        settingBtn.onClick.AddListener(delegate
        {
            TweenAnim.Instance.ShowPopUpTween(settingPanel.transform);
            settingPanel.SetActive(true);
        });

        homeBtn.onClick.AddListener(delegate
        {
            ASyncLoader.Instance.LoadLevel("Menu");
        });
    }

    private void Update()
    {
        Debug.Log(Time.timeScale);
    }
}
