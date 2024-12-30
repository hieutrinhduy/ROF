using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class Bomb : MonoBehaviour
{
    private Health health;
    public float expForce, radius;
    public GameObject explodeEffect;
    public int damage;
    bool exploded;
    private CinemachineImpulseSource cinemachineImpulseSource;

    private AudioSource audioSource;
    [SerializeField] private AudioClip explodeClip;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        health = GetComponent<Health>();
        exploded = false;
        cinemachineImpulseSource= GetComponent<CinemachineImpulseSource>();
    }
 
    public void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        Instantiate(explodeEffect, transform.position, Quaternion.identity);
        exploded = true;
        cinemachineImpulseSource.GenerateImpulse();
        Debug.Log("Explode");
        if (!AudioManager.Instance.sfxSource.mute)
        {
            audioSource.PlayOneShot(explodeClip);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
