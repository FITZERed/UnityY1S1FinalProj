using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] EnemyShoot enemyShoot;
    [SerializeField] EnemyRotate enemyRotate;
    [SerializeField] Rigidbody2D rigidbod;
    [SerializeField] BoxCollider2D collider;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("IM SHOT!!!! OUCH!!!!");
        OnDeath();
        _animator.SetTrigger("Die");
    }
    public void OnDeath()
    {
        Debug.Log("I actually am dying");
        enemyRotate.enabled = false;
        enemyShoot.enabled = false;
        Debug.Log(enemyShoot.enabled);
        collider.enabled = false;

    }
}
