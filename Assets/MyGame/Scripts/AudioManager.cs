using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioClip musicClip;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicClip;
        audioSource.loop = true;
        audioSource.Play();
    }
}
