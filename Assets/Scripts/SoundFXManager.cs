using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXManager : MonoBehaviour
{
    [SerializeField] AudioClip shot556;
    AudioSource audioSource;

    public static SoundFXManager Instance;
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
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(string soundName)
    {
        switch (soundName) 
        {
            case "Shot556":
                  audioSource.PlayOneShot(shot556);
                break;
                //place for more soundFX in new cases
        }
    }
}
