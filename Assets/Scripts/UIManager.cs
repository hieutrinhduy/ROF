using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Button playerStatusBtn;
    [SerializeField] GameObject playerStatusPanel;
    [SerializeField] GameObject pausePanel;
    [SerializeField] Button closePlayerStatusPanelBtn;
    [SerializeField] Button pauseBtn;

    [Header("For Animation")]
    [SerializeField] GameObject playerBar; 
    [SerializeField] GameObject skillBar; 

    private void Start()
    {

        TweenAnim.Instance.MoveFromTopToScreen(playerBar.transform);
        TweenAnim.Instance.MoveFromBottomToScreen(skillBar.transform);
        TweenAnim.Instance.MoveFromLeftToScreen(playerStatusBtn.transform);
        TweenAnim.Instance.MoveFromLeftToScreen(pauseBtn.transform);

        playerStatusBtn.onClick.AddListener(delegate
        {
            TweenAnim.Instance.ShowPopUpTween(playerStatusPanel.transform);
            //playerStatusPanel.SetActive(true);
            Time.timeScale = 0;
        });
        closePlayerStatusPanelBtn.onClick.AddListener(delegate
        {
            //playerStatusPanel.SetActive(false);
            TweenAnim.Instance.HidePopUpTween(playerStatusPanel.transform);
            Time.timeScale = 1;
        });
        pauseBtn.onClick.AddListener(delegate
        {
            TweenAnim.Instance.ShowPopUpTween(pausePanel.transform);
            //pausePanel.SetActive(true);
            Time.timeScale = 0;
        });
    }
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            //playerStatusPanel.SetActive(true);
            TweenAnim.Instance.ShowPopUpTween(playerStatusPanel.transform);
            Time.timeScale = 0;
        }
    }
}
