using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerceptiveStar : MonoBehaviour
{
    [SerializeField] Image image;
    void Start()
    {
        if (PlayerPrefs.HasKey("Perceptive"))
        {
            if (PlayerPrefs.GetInt("Perceptive") == 0)
            {
                image.enabled = false;
            }
            else if (PlayerPrefs.GetInt("Perceptive") == 1)
            {
                image.enabled = true;
            }
        }
        else { PlayerPrefs.SetInt("Perceptive", 0); }
    }
    private void Update()
    {
        if (!PlayerPrefs.HasKey("Perceptive"))
        {
            image.enabled = false;
        }
    }
}
