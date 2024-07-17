using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] GameObject enemyBullet;
    [SerializeField] GameObject enemyBarrel;
    [SerializeField] GameObject enemyCrossair;
    [SerializeField] float enemyBulletSpeed = 750f;
    [SerializeField] GameObject bulletParent;
    public int BulletsInChamber;
    private float initialDelay;
    private float shootingInterval;
    private Animator _animator;
    float timer;
    private void Awake()
    {
        BulletsInChamber = 6;
    }
    void Start()
    {
        StandoffManager.Instance.EnemyList.Add(gameObject);
        _animator = GetComponent<Animator>();
        initialDelay = Random.Range(1f, 3f);
        shootingInterval = Random.Range(1f, 3f);
    }

    
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shootingInterval && _animator.GetBool("GunPointed") && BulletsInChamber > 0)
        {
            shootingInterval = Random.Range(1f, 3f);
            timer = 0f;
            InstantiateEnemyBullet();
            BulletsInChamber--;
        }
    }
    private void InstantiateEnemyBullet()
    {
        SoundFXManager.Instance.PlaySound("Shot556");
        BulletManager.Instance.SpawnBullet(enemyBarrel, enemyBullet, enemyCrossair, enemyBulletSpeed);
    }
}
