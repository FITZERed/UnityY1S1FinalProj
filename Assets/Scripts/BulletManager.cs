using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Mathematics;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public static BulletManager Instance { get; private set; }
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void SpawnBullet(GameObject barrel, GameObject bullet, GameObject crossair, float bulletSpeed)
    {
        float barrelPositionX = barrel.transform.position.x;
        float barrelPositionY = barrel.transform.position.y;
        quaternion barrelDirection = barrel.transform.rotation;
        Vector2 barrelLocationVector = new Vector2(barrelPositionX, barrelPositionY);
        GameObject bulletClone = Instantiate(bullet, barrelLocationVector, barrelDirection, transform);
        Rigidbody2D bulletPhysics = bulletClone.GetComponent<Rigidbody2D>();
        Vector2 bulletDirection = (crossair.transform.position - barrel.transform.position).normalized;
        bulletPhysics.velocity = bulletDirection * bulletSpeed * Time.fixedDeltaTime;
    }
}
