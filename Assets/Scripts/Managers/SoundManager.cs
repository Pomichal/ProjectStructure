using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public SoundBehaviour soundPrefab;

    public List<AudioClip> sounds;

    // Start is called before the first frame update
    void Start()
    {
        App.soundManager = this;
    }

    public void PlaySound(int soundId, Vector3 position)
    {
        var instance = Instantiate(soundPrefab, position, Quaternion.identity, transform);
        instance.Setup(sounds[soundId]);
    }

}
