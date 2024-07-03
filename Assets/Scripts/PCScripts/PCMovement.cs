using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCMovement : MonoBehaviour
{
    [SerializeField] float pcSpeed = 10f;
    float horizontalInput;
    float verticalInput;

    private void Awake()
    {
        StandoffManager.Instance.Player = gameObject;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(horizontalInput * Time.deltaTime * pcSpeed, verticalInput * Time.deltaTime * pcSpeed), Space.World);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -9f, 9f), Mathf.Clamp(transform.position.y, -5f, 5f));

        

    }
}
