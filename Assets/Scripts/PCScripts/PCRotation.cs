using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCRotation : MonoBehaviour
{
    private Camera mainCam;
    private Vector3 mousePos;
    
    void Start()
    {
        mainCam = FindAnyObjectByType<Camera>();
    }

   
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + 90);
    }
}
