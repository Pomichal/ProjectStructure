using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBehaviour : MonoBehaviour
{
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void Setup(AudioClip clip)
    {
        source.clip = clip;
        source.Play();
        // setup the timer to clip.length and destroy;
        Destroy(gameObject, clip.length);
    }
}
