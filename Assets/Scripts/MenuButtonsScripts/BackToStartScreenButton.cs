using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToStartScreenButton : MonoBehaviour
{
    public void BackToStartMenu()
    {
        SceneManager.LoadScene(0);
    }
}