using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] GameObject enemyBullet;
    [SerializeField] GameObject enemyBarrel;
    [SerializeField] GameObject enemyCrossair;
    [SerializeField] float enemyBulletSpeed = 750f;
    GameObject bulletParent;
    public int BulletsInChamber;
    private float initialDelay;
    private float shootingInterval;
    private Animator _animator;
    private void Awake()
    {
        StandoffManager.Instance.EnemyList.Add(gameObject);
        bulletParent = GameObject.Find("Bullet_Parent");
        BulletsInChamber = 6;
    }
    void Start()
    {
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
        float enemyBarrelPositionX = enemyBarrel.transform.position.x;
        float enemyBarrelPositionY = enemyBarrel.transform.position.y;
        Quaternion enemyBarrelDirection = enemyBarrel.transform.rotation;
        Vector2 enemyBarrelLocationVector = new Vector2(enemyBarrelPositionX, enemyBarrelPositionY);
        GameObject enemyBulletClone = Instantiate(enemyBullet, enemyBarrelLocationVector, enemyBarrelDirection, bulletParent.transform);
        Rigidbody2D enemyBulletPhysics = enemyBulletClone.GetComponent<Rigidbody2D>();
        Vector2 enemyBulletDirection = (enemyCrossair.transform.position - enemyBarrel.transform.position).normalized;
        enemyBulletPhysics.velocity = enemyBulletDirection * enemyBulletSpeed * Time.fixedDeltaTime;
    }
}
