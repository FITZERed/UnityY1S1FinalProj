using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseTexts : MonoBehaviour
{
    public static WinLoseTexts Instance;
    [SerializeField] public GameObject WinScreenStuff;
    [SerializeField] public GameObject LoseScreenStuff;
    [SerializeField] public GameObject Player;
    public PlayerDeath playerDeath;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        WinScreenStuff.SetActive(false);
        LoseScreenStuff.SetActive(false);
        playerDeath = Player.GetComponent<PlayerDeath>();
    }
    private void Update()
    {
        if (StandoffManager.Instance.EnemyList.Count <= 0)
        {
            WinScreenStuff.SetActive(true);
        }
    }
    public void TriggerLoss()
    {
        LoseScreenStuff.SetActive(true);
    }
}
