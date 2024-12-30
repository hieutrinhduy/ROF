using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening.Core.Easing;

public class MenuController : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] Button continueButton;
    [SerializeField] Button quitButton;
    [SerializeField] Button optionButton;

    [SerializeField] GameObject settingPanel;

    [SerializeField] GameObject heading;

    private void Awake()
    {
        Time.timeScale = 1;
        if (PlayerPrefs.HasKey("LastPlayedScene") && PlayerPrefs.GetString("LastPlayedScene") != "Menu")
        {
            continueButton.gameObject.SetActive(true);
        }
        else
        {
            continueButton.gameObject.SetActive(false);
        }
    }
    private void Start()
    {
        AudioManager.Instance.musicSource.Stop();
        AudioManager.Instance.PlayMusic("MenuBGM");

        if (TweenAnim.Instance)
        {
            TweenAnim.Instance.MoveFromTopToScreen(heading.transform);
        }

        startButton.onClick.AddListener(delegate
        {
            PlayerPrefs.DeleteKey("PlayerLevel");
            PlayerPrefs.DeleteKey("currentExp");
            PlayerPrefs.DeleteKey("neededExpNextLevel");
            PlayerPrefs.DeleteKey("HealthBonus");
            PlayerPrefs.DeleteKey("AtkBonus");
            PlayerPrefs.DeleteKey("SkillPoint");
            ASyncLoader.Instance.LoadLevel("CutScene");
        });

        continueButton.onClick.AddListener(delegate
        {
            ASyncLoader.Instance.LoadLevel(PlayerPrefs.GetString("LastPlayedScene"));
        });

        optionButton.onClick.AddListener(delegate
        {
            //settingPanel.SetActive(true);
            TweenAnim.Instance.ShowPopUpTween(settingPanel.transform);
        });

        quitButton.onClick.AddListener(delegate
        {
            Application.Quit();
        });
    }

    private void OnDestroy()
    {
        startButton.onClick.RemoveAllListeners();
        optionButton.onClick.RemoveAllListeners();
        continueButton.onClick.RemoveAllListeners();
        quitButton.onClick.RemoveAllListeners();
    }
}
