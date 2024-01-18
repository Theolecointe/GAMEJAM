using UnityEngine;

public class AmbianceController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAmbiance()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }

    public void StopAmbiance()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
    }

   
}