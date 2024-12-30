using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPX : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (AudioManager.Instance.sfxSource.mute)
        {
            audioSource.enabled = false;
        }
    }
}
