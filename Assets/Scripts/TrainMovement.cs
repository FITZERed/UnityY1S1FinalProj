using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    [SerializeField] float trainDelay;
    [SerializeField] float trainSpeed;
    float timer;


    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= trainDelay)
        {
            transform.Translate(-trainSpeed * Time.fixedDeltaTime, 0, 0);
        }
    }

}
