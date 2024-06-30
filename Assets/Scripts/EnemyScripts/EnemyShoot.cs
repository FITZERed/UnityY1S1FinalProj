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
    private int bulletsInChamber;
    private float initialDelay;
    private float shootingInterval;
    private void Awake()
    {
        bulletParent = GameObject.Find("Bullet_Parent");
        bulletsInChamber = 6;
    }
    void Start()
    {
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
        while (bulletsInChamber > 0)
        {
                shootingInterval = Random.Range(1f, 3f);
                InstantiateEnemyBullet();
                bulletsInChamber--;
                yield return new WaitForSeconds(shootingInterval);
     
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
