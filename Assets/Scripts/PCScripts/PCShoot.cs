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
    GameObject bulletParent;

    private void Awake()
    {
        bulletParent = GameObject.Find("Bullet_Parent");
    }
   
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0)) 
        {
            InstantiateBullet();
        }
    }

    private void InstantiateBullet()
    {
        SoundFXManager.Instance.PlaySound("Shot556");
        float barrelPositionX = barrel.transform.position.x;
        float barrelPositionY = barrel.transform.position.y;
        quaternion barrelDirection = barrel.transform.rotation;
        Vector2 barrelLocationVector = new Vector2(barrelPositionX, barrelPositionY);
        GameObject bulletClone = Instantiate(bullet, barrelLocationVector, barrelDirection, bulletParent.transform);
        Rigidbody2D bulletPhysics = bulletClone.GetComponent<Rigidbody2D>();
        Vector2 bulletDirection = (crossair.transform.position - barrel.transform.position).normalized;
        bulletPhysics.velocity = bulletDirection * bulletSpeed * Time.fixedDeltaTime;

    }
}
