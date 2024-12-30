using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXController : MonoBehaviour
{
    [SerializeField] Button closeButton;

    [SerializeField] Toggle musicToggle;
    [SerializeField] Toggle soundToggle;

    [SerializeField] GameObject noMusicImage;
    [SerializeField] GameObject noSoundImage;

    [SerializeField] Slider musicSlider;
    [SerializeField] Slider soundSlider;

    [SerializeField] GameObject settingPanel;


    private void Start()
    {
        closeButton.onClick.AddListener(delegate
        {
            TweenAnim.Instance.HidePopUpTween(settingPanel.transform);
        });

        musicToggle.onValueChanged.AddListener(delegate
        {
            if (musicToggle.isOn)
            {
                noMusicImage.gameObject.SetActive(false);
                AudioManager.Instance.ToggleMusic(true);
                musicSlider.value = musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
                PlayerPrefs.SetInt("Music", 1);
            }
            else
            {
                noMusicImage.gameObject.SetActive(true);
                AudioManager.Instance.ToggleMusic(false);
                musicSlider.value = 0;
                PlayerPrefs.SetInt("Music", 0);
            }
        });

        soundToggle.onValueChanged.AddListener(delegate
        {
            if (soundToggle.isOn)
            {
                noSoundImage.gameObject.SetActive(false);
                AudioManager.Instance.ToggleSFX(true);
                PlayerPrefs.SetInt("SFX", 1);
            }
            else
            {
                noSoundImage.gameObject.SetActive(true);
                AudioManager.Instance.ToggleSFX(false);
                PlayerPrefs.SetInt("SFX", 0);
            }
        });

        musicSlider.onValueChanged.AddListener(delegate
        {
            AudioManager.Instance.MusicVolume(musicSlider.value);
            if (musicSlider.value <= 0)
            {
                musicToggle.isOn = false;
            }
            else
            {
                musicToggle.isOn = true;
            }
        });

        soundSlider.onValueChanged.AddListener(delegate
        {
            AudioManager.Instance.MusicVolume(soundSlider.value);
            if (soundSlider.value <= 0)
            {
                soundToggle.isOn = false;
            }
            else
            {
                soundToggle.isOn = true;
            }
        });


        //Load user Setting
        if (PlayerPrefs.HasKey("Music"))
        {
            soundToggle.isOn = PlayerPrefs.GetInt("Music", 1) == 1 ? true : false;
        }
        else
        {
            PlayerPrefs.SetInt("Music", 1);
            soundToggle.isOn = PlayerPrefs.GetInt("Music", 1) == 1 ? true : false;
        }


        if (PlayerPrefs.HasKey("SFX"))
        {
            soundToggle.isOn = PlayerPrefs.GetInt("SFX", 1) == 1 ? true : false;
        }
        else
        {
            PlayerPrefs.SetInt("SFX", 1);
            soundToggle.isOn = PlayerPrefs.GetInt("SFX", 1) == 1 ? true : false;
        }


        if (PlayerPrefs.HasKey("MusicVolume"))
        {
            musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
            if(musicSlider.value > 0)
            {
                musicToggle.isOn = true;
            }
        }
        else
        {
            PlayerPrefs.SetFloat("MusicVolume", 1F);
            musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
        }
    }



    private void OnDestroy()
    {
        closeButton.onClick.RemoveAllListeners();
        musicToggle.onValueChanged.RemoveAllListeners();
        musicSlider.onValueChanged.RemoveAllListeners();
        soundToggle.onValueChanged.RemoveAllListeners();
        soundSlider.onValueChanged.RemoveAllListeners();
    }
}
