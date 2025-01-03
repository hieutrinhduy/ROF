using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using System.Diagnostics.Tracing;
using UnityEngine.Audio;
using TMPro;

public class Health : MonoBehaviour
{
    public bool IsBoss;
    public bool IsImmortal;

    public static Action<Health> OnDeath;
    public bool IsDead {  get; private set; }
    public int startingHealth = 3;

    private Health health;

    public float currentHealth;

    [SerializeField] private Image HpBarFillAmount;
    [SerializeField] private GameObject HpBar;

    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material whiteMaterial;
    [SerializeField] private float whiteFlashTime;
    [SerializeField] private SkinnedMeshRenderer[] playerVisuals;
    [SerializeField] private MeshRenderer[] playerMeshVisuals;
    [SerializeField] private AIEnemy aIEnemy;
    Animator animator;
    [SerializeField] private GameObject dropedExpPrefab;
    [SerializeField] private GameObject BloodSplatterFx;

    [SerializeField] private AudioSource audioSource;

    private Bomb bomb;

    [SerializeField] private TMP_Text healthText; 
    private void Start()
    {
        animator = GetComponent<Animator>();
        aIEnemy = GetComponent<AIEnemy>();
        bomb= GetComponent<Bomb>();
        audioSource = GetComponent<AudioSource>();
        IsDead = false;
        currentHealth = startingHealth;
    }
    private void Awake()
    {
        health = GetComponent<Health>();
    }
    private void Update()
    {
        if (HpBarFillAmount != null)
        {
            HpBarFillAmount.fillAmount = (float)currentHealth/startingHealth;
        }
        if(healthText != null)
        {
            healthText.text = ((int)currentHealth).ToString() + " / " + startingHealth.ToString();
        }
    }
    public void ResetHealth()
    {
        currentHealth = startingHealth;
    }

    public void TakeDamage(float amount)
    {
        if(IsImmortal)
        {
            return;
        }
        currentHealth -= amount;
        if(amount >0 && audioSource && !AudioManager.Instance.sfxSource.mute)
        {
            audioSource.Play();
        }
        Debug.Log("- " + amount);
        StartCoroutine(WhiteFlashRountine(whiteFlashTime));
        if(BloodSplatterFx != null)
        {
            Instantiate(BloodSplatterFx, transform.position, Quaternion.identity);
        }
        if (currentHealth <= 0)
        {
            animator.ResetTrigger("Hit"); // Reset any "Hit" triggers
            animator.SetTrigger("Die");
            IsDead = true;
            if(bomb != null)
            {
                bomb.Explode();
            }
            if (HpBar != null)
            {
                //HpBar.transform.parent.gameObject.SetActive(false);
                HpBar.gameObject.SetActive(false);
            }
            if(aIEnemy != null)
            {
                aIEnemy.isDead = true;
            }
            if(HpBar != null)
            {
                HpBar.SetActive(false);
            }
            OnDeath?.Invoke(this);
            if(IsBoss) Destroy(gameObject, 2f);
            else Destroy(gameObject, 1f);
            if(dropedExpPrefab != null)
            {
                if (IsBoss)
                {
                    Instantiate(dropedExpPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                }
                else
                {
                    Instantiate(dropedExpPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                }
            }
        }
        else
        {

            animator.SetTrigger("Hit");
        }
    }

    IEnumerator WhiteFlashRountine(float time)
    {
        foreach (SkinnedMeshRenderer player in playerVisuals)
        {
            player.material = whiteMaterial;
        }
        foreach (MeshRenderer player in playerMeshVisuals)
        {
            player.material = whiteMaterial;
        }
        yield return new WaitForSeconds(time);
        foreach (SkinnedMeshRenderer player in playerVisuals)
        {
            player.material = defaultMaterial;
        }
        foreach (MeshRenderer player in playerMeshVisuals)
        {
            player.material = defaultMaterial;
        }
    }


    public void TakeDamage(Vector2 DamageSourceDir, int damageAmout, float knockBackThurst)
    {
        health.TakeDamage(damageAmout);
    }

    public void TakeHit()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Health"))
        {
            currentHealth += 30;
            if (currentHealth > startingHealth)
            {
                currentHealth = startingHealth;
            }
            Destroy(collision.gameObject);
        }
    }

}