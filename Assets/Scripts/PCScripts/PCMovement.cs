using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCMovement : MonoBehaviour
{
    [SerializeField] public float pcSpeed = 10f;
    float horizontalInput;
    float verticalInput;

    private void Awake()
    {
        
    }
    void Start()
    {
        StandoffManager.Instance.Player = gameObject;
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(horizontalInput * Time.deltaTime * pcSpeed, verticalInput * Time.deltaTime * pcSpeed), Space.World);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -17f, 17f), Mathf.Clamp(transform.position.y, -17f, 17f));

        

    }
}
