using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusPanel : MonoBehaviour
{
    [SerializeField] private Text levelTxt;
    [SerializeField] private Text skillPointTxt;

    [SerializeField] private Text HPText;
    [SerializeField] private Text AttackText;
    [SerializeField] private Text SpeedText;
    [SerializeField] private Text DefendText;

    [SerializeField] private Button HPBtn;
    [SerializeField] private Button ATKBtn;

    [SerializeField] private Health playerHealth;
    [SerializeField] private Sword swordDame;

    int skillPoint;

    private void OnEnable()
    {
        levelTxt.text = "Cấp độ: " + PlayerPrefs.GetInt("PlayerLevel").ToString();
        skillPointTxt.text = "Điểm kỹ năng: " + PlayerPrefs.GetInt("SkillPoint").ToString();

        HPText.text = "Máu: " + playerHealth.startingHealth.ToString();
        AttackText.text = "Tấn công: " + swordDame.damageAmount.ToString();

        skillPoint = PlayerPrefs.GetInt("SkillPoint");
        CheckSkillPoint();
    }

    private void Start()
    {
        HPBtn.onClick.AddListener(delegate
        {
            if (PlayerPrefs.HasKey("HealthBonus"))
            {
                int tmp = PlayerPrefs.GetInt("HealthBonus");
                tmp += 5;
                PlayerPrefs.SetInt("HealthBonus", tmp);
                playerHealth.startingHealth += 5;
                HPText.text = "Máu: " + playerHealth.startingHealth.ToString();
                skillPoint -= 1;
                PlayerPrefs.SetInt("SkillPoint", skillPoint);
                CheckSkillPoint();

            }
            else
            {
                PlayerPrefs.SetInt("HealthBonus", 5);
                skillPoint -= 1;
                PlayerPrefs.SetInt("SkillPoint", skillPoint);
                playerHealth.startingHealth += 5;
                HPText.text = "Máu: " + playerHealth.startingHealth.ToString();
                CheckSkillPoint();
            }
        });

        ATKBtn.onClick.AddListener(delegate
        {
            if (PlayerPrefs.HasKey("AtkBonus"))
            {
                int tmp = PlayerPrefs.GetInt("AtkBonus");
                tmp += 1;
                PlayerPrefs.SetInt("AtkBonus", tmp);
                swordDame.damageAmount += 1;
                AttackText.text = "Tấn công: " + swordDame.damageAmount.ToString();
                skillPoint -= 1;
                PlayerPrefs.SetInt("SkillPoint", skillPoint);
                CheckSkillPoint();
            }
            else
            {
                PlayerPrefs.SetInt("AtkBonus", 1);
                skillPoint -= 1;
                PlayerPrefs.SetInt("SkillPoint", skillPoint);
                swordDame.damageAmount += 1;
                AttackText.text = "Tấn công: " + swordDame.damageAmount.ToString();
                CheckSkillPoint();
            }
        });
    }

    private void Update()
    {
    }

    private void CheckSkillPoint()
    {
        skillPointTxt.text = "Điểm kỹ năng: " + PlayerPrefs.GetInt("SkillPoint").ToString();
        if (skillPoint > 0)
        {
            HPBtn.interactable = true;
            ATKBtn.interactable = true;
        }
        else
        {
            HPBtn.interactable = false;
            ATKBtn.interactable = false;
        }
    }
}
