using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip menuMusic;
    public AudioClip inGameMusic;

    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        App.musicManager = this;
    }

    public void SetMusic(Music type)
    {
        if(type == Music.Menu)
        {
            source.clip = menuMusic;
        }
        else
        {
            source.clip = inGameMusic;
        }
        source.Play();
    }
}
