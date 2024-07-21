using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCPickUpBriefcase : MonoBehaviour
{
    private bool _isCasePickedUp;

    private void Start()
    {
        _isCasePickedUp = false;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Briefcase" && Input.GetKeyDown(KeyCode.E))
        {
            _isCasePickedUp = true;
            Debug.Log("Briefcase achievement Unlocked");
            PlayerPrefs.SetInt("Perceptive", 1);
            //show briefcase, msg player, set achievement
        }
    }
}
