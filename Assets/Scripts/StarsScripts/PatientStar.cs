using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PatientStar : MonoBehaviour
{
    [SerializeField] Image image;
    void Start()
    {
        if (PlayerPrefs.HasKey("Patient"))
        {
            if (PlayerPrefs.GetInt("Patient") == 0)
            {
                image.enabled = false;
            }
            else if (PlayerPrefs.GetInt("Patient") == 1)
            {
                image.enabled = true;
            }
        }
        else { PlayerPrefs.SetInt("Patient", 0); }
    }
    private void Update()
    {
        if (!PlayerPrefs.HasKey("Patient"))
        {
            image.enabled = false;
        }
    }
}
