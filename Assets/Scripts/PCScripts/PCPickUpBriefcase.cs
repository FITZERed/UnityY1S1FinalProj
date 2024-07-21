using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PCPickUpBriefcase : MonoBehaviour
{
    private bool _isCasePickedUp;
    [SerializeField] public Image BriefcaseImage;
    [SerializeField] public TMP_Text BriefcaseText;
    public void Start()
    {
        _isCasePickedUp = false;
        BriefcaseText.enabled = false;
        BriefcaseImage.enabled = false;
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Briefcase")
        {
            BriefcaseText.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                BriefcaseImage.enabled = true;
                _isCasePickedUp = true;
                Debug.Log("Briefcase achievement Unlocked");
                PlayerPrefs.SetInt("Perceptive", 1);
                //show briefcase, msg player, set achievement
            }
        }
    }
}
