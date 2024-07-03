using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandoffManager : MonoBehaviour
{

    public List<GameObject> EnemyList;
    [SerializeField] public GameObject Player;
    public StandoffState State;
    public static StandoffManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        State = StandoffState.Standoff;
        foreach (GameObject enemy in EnemyList)
        {
            enemy.GetComponent<Animator>().SetBool("GunPointed", false);
        }
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            State = StandoffState.Shootout;
        }

        if (State == StandoffState.Shootout)
        {
            Player.GetComponent<Animator>().SetBool("GunPointed", true);
            foreach (GameObject enemy in EnemyList)
            {
                enemy.GetComponent<Animator>().SetBool("GunPointed", true);
            }
        }
    }
}

public enum StandoffState
{
    Standoff,
    Shootout
}