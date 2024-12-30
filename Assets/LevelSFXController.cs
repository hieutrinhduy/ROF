using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSFXController : MonoBehaviour
{
    [SerializeField] string musicName;

    private void Start()
    {
        AudioManager.Instance.musicSource.Stop();
        AudioManager.Instance.PlayMusic(musicName);
    }
}
