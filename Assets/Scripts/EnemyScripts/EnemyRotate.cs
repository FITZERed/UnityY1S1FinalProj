using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRotate : MonoBehaviour
{
    GameObject TargetPlayer;
    Vector3 playerPos;
    Animator _animator;
    private void Awake()
    {
        
        
    }
    void Start()
    {
        TargetPlayer = GameObject.Find("CowboyTopDown");
        _animator = GetComponent<Animator>();
    }

   
    void Update()
    {
            playerPos = TargetPlayer.transform.position;
            Vector3 rotation = playerPos - transform.position;
            float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotZ + 90);
    }
}
