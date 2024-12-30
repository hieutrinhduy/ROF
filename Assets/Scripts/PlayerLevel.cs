using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;
using System.Data;
public class PlayerLevel : MonoBehaviour
{
    [SerializeField] private Image ExpBar;
    [SerializeField] private TMP_Text LevelText;
    [SerializeField] private TMP_Text ExpProgress;

    [SerializeField] private int level;
    private int currentExp;
    [SerializeField] private int neededExpNextLevel;
    private int remainingExp;
    [SerializeField] private GameObject LevelUpFx;

    private AudioSource audioSource;
    [SerializeField] private AudioClip levelUpClip;

    private Health health;
    [SerializeField] private Sword swordDame;

    private int currentSkillPoint;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        health = GetComponent<Health>();

        if(PlayerPrefs.HasKey("PlayerLevel"))
        {
            level = PlayerPrefs.GetInt("PlayerLevel");
            LevelText.text = level.ToString();
        }
        else
        {
            level = 1;
            PlayerPrefs.SetInt("PlayerLevel", 1);
        }

        if (PlayerPrefs.HasKey("currentExp"))
        {
            currentExp = PlayerPrefs.GetInt("currentExp");
        }
        else
        {
            currentExp = 0;
            PlayerPrefs.SetInt("currentExp", 0);
        }

        if (PlayerPrefs.HasKey("neededExpNextLevel"))
        {
            neededExpNextLevel = PlayerPrefs.GetInt("neededExpNextLevel");
        }
        else
        {
            neededExpNextLevel = 10;
            PlayerPrefs.SetInt("neededExpNextLevel", 10);
        }



        if (PlayerPrefs.HasKey("HealthBonus"))
        {
            health.startingHealth += PlayerPrefs.GetInt("HealthBonus");
        }

        if (PlayerPrefs.HasKey("AtkBonus"))
        {
            swordDame.damageAmount += PlayerPrefs.GetInt("AtkBonus");
        }

        if (PlayerPrefs.HasKey("SkillPoint"))
        {
            currentSkillPoint = PlayerPrefs.GetInt("SkillPoint");
        }
        else
        {
            currentSkillPoint = 0;
            PlayerPrefs.SetInt("SkillPoint", currentSkillPoint);
        }

        UpdateStatus();
        health.currentHealth = health.startingHealth;
    }

    private void UpdateStatus()
    {
        health.startingHealth += (int)(level -1) * 5;
        swordDame.damageAmount += (int)(level -1) * 1;
    }

    private void Update()
    {
        ExpBar.fillAmount = (float)currentExp/neededExpNextLevel;
        ExpProgress.text = currentExp.ToString() + " / " + neededExpNextLevel.ToString();
    }

    public void EarnExp(int claimedExp)
    {
        currentExp += claimedExp;
        Debug.Log("Claim EXP");
        if(currentExp >= neededExpNextLevel)
        {
            remainingExp= currentExp - neededExpNextLevel;
            LevelUp();
        }
        PlayerPrefs.SetInt("currentExp", currentExp);
    }

    private void LevelUp()
    {
        if (!AudioManager.Instance.sfxSource.mute)
        {
            audioSource.PlayOneShot(levelUpClip);
        }
        level += 1;
        currentExp = 0 + remainingExp;
        PlayerPrefs.SetInt("currentExp", currentExp);
        remainingExp = 0;
        neededExpNextLevel += 10;
        PlayerPrefs.SetInt("neededExpNextLevel", neededExpNextLevel);
        LevelText.text = level.ToString();
        currentSkillPoint += 1;
        PlayerPrefs.SetInt("SkillPoint", currentSkillPoint);
        health.startingHealth += 5;
        swordDame.damageAmount += 1;
        PlayerPrefs.SetInt("PlayerLevel", level);
        StartCoroutine(LevelUpRountine());
    }
    private IEnumerator LevelUpRountine()
    {
        LevelUpFx.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        LevelUpFx.SetActive(false);
    }
}
