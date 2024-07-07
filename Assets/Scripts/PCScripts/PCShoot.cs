using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PCShoot : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    [SerializeField] GameObject barrel;
    [SerializeField] GameObject crossair;
    [SerializeField] float bulletSpeed = 1000f;
    [SerializeField] GameObject bulletParent;
    [SerializeField] int bulletsInGun;

    private void Awake()
    {
        bulletsInGun = 6;
    }
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) && bulletsInGun > 0) 
        {
            InstantiateBullet();
            bulletsInGun--;
        }
    }

    private void InstantiateBullet()
    {
        BulletManager.Instance.SpawnBullet(barrel, bullet, crossair, bulletSpeed);
    }
}
