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
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collisionObject)
    {
        if (collisionObject.tag == "Train")
        {
            //set achievement here
        }
        Debug.Log("IM SHOT!!!! OUCH!!!!");
        _animator.SetTrigger("Die");
        OnDeath();
        _animator.SetTrigger("Die");
    }
    public void OnDeath()
    {
        enemyShoot.BulletsInChamber = 0;
        Debug.Log("I actually am dying");
        enemyRotate.enabled = false;
        enemyShoot.enabled = false;
        Debug.Log(enemyShoot.enabled);
        collider.enabled = false;
        StandoffManager.Instance.EnemyList.Remove(gameObject);
    }
}
