using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class KnockBack : MonoBehaviour
{
    public bool IsImmortal;
    private Vector3 _hitDirection;
    private Rigidbody _rb;
    private bool isKnockback = false;
    private float knockbackDuration = 0.5f;

    private NavMeshAgent NavMeshAgent;
    private float oldSpeed;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        NavMeshAgent = GetComponent<NavMeshAgent>();
    }

    public void GetKnockBack(Vector3 hitPosition, int knockBackThrust)
    {
        if (IsImmortal) return;
        if (isKnockback) return;

        isKnockback = true;
        _hitDirection = (transform.position - hitPosition).normalized;

        if (_rb != null)
        {
            if (NavMeshAgent != null)
            {
                oldSpeed = NavMeshAgent.speed;
                NavMeshAgent.enabled = false;
            }

            _rb.isKinematic = false;
            _rb.AddForce(_hitDirection * knockBackThrust, ForceMode.Impulse);
            Debug.Log("HitDir: " + _hitDirection);
            Debug.Log("KnockBack");

            if (gameObject.activeInHierarchy)
            {
                StartCoroutine(ResetKnockback());
            }
        }
    }


    private IEnumerator ResetKnockback()
    {
        yield return new WaitForSeconds(knockbackDuration);

        if (gameObject != null)
        {
            if (_rb != null)
            {
                _rb.velocity = Vector3.zero;
                _rb.isKinematic = true;
            }
            if (NavMeshAgent != null)
            {
                NavMeshAgent.enabled = true;
                NavMeshAgent.speed = oldSpeed;
            }
            isKnockback = false;
        }
    }

}
