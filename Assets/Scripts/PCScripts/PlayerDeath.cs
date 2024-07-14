using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private Animator _animator;
    [SerializeField] PCMovement _pMovement;
    [SerializeField] PCRotation _pRotation;
    [SerializeField] PCShoot _pShoot;
    [SerializeField] BoxCollider2D collider;
    int _hp;
    
    private void Awake()
    {
        _hp = 2;
    }
    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (_hp <= 0)
        {
            _animator.SetTrigger("Die");
            _pMovement.enabled = false;
            _pRotation.enabled = false;
            _pShoot.enabled = false;
            WinLoseTexts.Instance.TriggerLoss();
        }
    }
    public void OnTriggerEnter2D(Collider2D collisionObject)
    {
        if (collisionObject.tag == "EnemyBullet")
        {
            PlayerHit();
        }
    }
    public void PlayerHit()
    {
        _hp--;
        _pMovement.pcSpeed -= 1;
    }
}
