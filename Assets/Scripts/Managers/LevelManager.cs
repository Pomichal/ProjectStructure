using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public GameObject playerPrefab;

    void Awake()
    {
        App.levelManager = this;
    }

    public void Init()
    {
        Instantiate(playerPrefab);
    }
}
