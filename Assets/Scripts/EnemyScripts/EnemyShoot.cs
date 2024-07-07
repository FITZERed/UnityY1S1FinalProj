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
    private void Awake()
    {
        BulletsInChamber = 6;
    }
    void Start()
    {
        StandoffManager.Instance.EnemyList.Add(gameObject);
        _animator = GetComponent<Animator>();
        initialDelay = Random.Range(1f, 3f);
        Invoke(nameof(StartShooting), initialDelay);
    }

    
    void Update()
    {
        
    }
    private void StartShooting()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        while (BulletsInChamber > 0)
        {
            if (_animator.GetBool("GunPointed"))
            {
                shootingInterval = Random.Range(1f, 3f);
                InstantiateEnemyBullet();
                BulletsInChamber--;
                yield return new WaitForSeconds(shootingInterval);
            }
        }
    }
    private void InstantiateEnemyBullet()
    {
        BulletManager.Instance.SpawnBullet(enemyBarrel, enemyBullet, enemyCrossair, enemyBulletSpeed);
    }
}
