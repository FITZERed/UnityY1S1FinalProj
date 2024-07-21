using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetAchievements : MonoBehaviour
{
    public void ResetProgress()
    {
        PlayerPrefs.DeleteAll();
    }
}
