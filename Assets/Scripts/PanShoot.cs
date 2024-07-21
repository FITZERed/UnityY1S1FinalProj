using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanShoot : MonoBehaviour
{
    [SerializeField] GameObject barrel;
    [SerializeField] GameObject crossair;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject bulletParent;
    [SerializeField] float deflectSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet") 
        {
            OnBulletHit();
        }
    }
    void OnBulletHit()
    {
        SoundFXManager.Instance.PlaySound("bulletRico");
        BulletManager.Instance.SpawnBullet(barrel, bullet, crossair, deflectSpeed);
        Debug.Log("Pan Achievement Unlocked");
        PlayerPrefs.SetInt("Resourceful", 1);
    }
}
