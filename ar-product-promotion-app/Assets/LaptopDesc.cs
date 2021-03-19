using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class LaptopDesc : MonoBehaviour
{
    public AudioClip[] audioClips;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudioClip(int index, bool isPlaying)
    {
        if(isPlaying)
        {
            audioSource.Stop();
            audioSource.clip = audioClips[index];
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
