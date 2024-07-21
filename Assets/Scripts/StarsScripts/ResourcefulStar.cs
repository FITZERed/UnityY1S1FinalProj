using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourcefulStar : MonoBehaviour
{
    [SerializeField] Image image;
    void Start()
    {
        if (PlayerPrefs.HasKey("Resourceful"))
        {
            if (PlayerPrefs.GetInt("Resourceful") == 0)
            {
                image.enabled = false;
            }
            else if (PlayerPrefs.GetInt("Resourceful") == 1)
            {
                image.enabled = true;
            }
        }
        else { PlayerPrefs.SetInt("Resourceful", 0); }
    }
    private void Update()
    {
        if (!PlayerPrefs.HasKey("Resourceful"))
        {
            image.enabled = false;
        }
    }
}
