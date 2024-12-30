using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Bullet : MonoBehaviour
{
    private GameObject player;
    private Vector3 fireDir;
    [SerializeField] private float moveSpeed;
    [SerializeField] private GameObject BulletHitFx;
    private Rigidbody rb;

    private AudioSource audioSource;


    private void Awake()
    {
        audioSource = GetComponentInChildren<AudioSource>();
        if (AudioManager.Instance.sfxSource.mute)
        {
            audioSource.enabled = false;
        }
    }


    private void Start()
    {
        Physics.IgnoreLayerCollision(9, 10, true);
        Physics.IgnoreLayerCollision(9, 11, true);
        Physics.IgnoreLayerCollision(9, 12, true);
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>(); 

        if (player != null)
        {
            fireDir = player.transform.position - gameObject.transform.position;
            rb.velocity = new Vector3(fireDir.x, fireDir.y, fireDir.z).normalized * moveSpeed;
        }
        else
        {
            Destroy(gameObject);
        }
        Destroy(gameObject, 8f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground")) return;
        if (other.gameObject.CompareTag("Enemy")) return;
        if (other.gameObject.name.Contains("Cube")) return;
        Instantiate(BulletHitFx, transform.position, Quaternion.identity);
        Debug.Log("Collider with: " + other.gameObject);
        Destroy(gameObject);
    }
}
