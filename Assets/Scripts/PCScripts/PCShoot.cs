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
    [SerializeField] float reloadTime;

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

        if (Input.GetKeyDown(KeyCode.R) && bulletsInGun == 0)
        {
            StartCoroutine(nameof(Reload));
        }
    }

    private void InstantiateBullet()
    {
        SoundFXManager.Instance.PlaySound("Shot556");
        BulletManager.Instance.SpawnBullet(barrel, bullet, crossair, bulletSpeed);
    }
    IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
        bulletsInGun++;
    }
}
