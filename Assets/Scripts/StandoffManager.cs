using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandoffManager : MonoBehaviour
{

    public List<GameObject> EnemyList = new();
    [SerializeField] public GameObject Player;
    public StandoffState State;
    public static StandoffManager Instance;
    private bool shootoutStarted;
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
    }

    void Start()
    {
        shootoutStarted = false;
        State = StandoffState.Standoff;
        foreach (GameObject enemy in EnemyList)
        {
            enemy.GetComponent<Animator>().SetBool("GunPointed", false);
        }
    }

    
    void Update()
    {
        if (shootoutStarted == false && (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)))
        {
            State = StandoffState.Shootout;
            UpdateState();
            shootoutStarted = true;
        }
    }
    private void UpdateState()
    {
        switch (State)
        {
            case StandoffState.Shootout:
                Player.GetComponent<Animator>().SetBool("GunPointed", true);
                foreach (GameObject enemy in EnemyList)
                {
                    enemy.GetComponent<Animator>().SetBool("GunPointed", true);
                }
                break;
        }
    }
}

public enum StandoffState
{
    Standoff,
    Shootout
}