using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InfoButton : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] TMP_Text text;

    private void Start()
    {
        image.enabled = false;
        text.enabled = false;
    }
    public void ShowAndHideInfo()
    {
        if (image.enabled == true)
        {
            image.enabled = false;
            text.enabled = false;
        }
        else if (image.enabled == false)
        {
            text.enabled = true;
            image.enabled = true;
        }
    }
}
