using UnityEngine;
using UnityEngine.InputSystem;

public class soundVélo : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if (Mouse.current.rightButton.wasPressedThisFrame)
        {
            PlayBell();
        }
    }

    void PlayBell()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }


    }
}