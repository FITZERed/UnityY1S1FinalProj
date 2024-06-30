using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collisionObject)
    {
        if (collisionObject.tag == "Wall")
        {

        }


        Destroy(gameObject);
    }
}
