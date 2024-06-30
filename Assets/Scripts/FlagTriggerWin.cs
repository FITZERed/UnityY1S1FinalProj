using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagTriggerWin : MonoBehaviour
{
    
    void Start()
    {
        
    }

  
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collisionObject)
    {
        Debug.Log(collisionObject.tag);
        if (collisionObject.tag == "Player")
        {
            Debug.Log("WIN");
            SceneManager.LoadScene(2);
        }
    }
}
