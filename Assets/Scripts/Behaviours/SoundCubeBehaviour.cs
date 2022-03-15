using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCubeBehaviour : MonoBehaviour
{

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlaySound();
        }

    }

    private void PlaySound()
    {
        source.Play();
    }
}
