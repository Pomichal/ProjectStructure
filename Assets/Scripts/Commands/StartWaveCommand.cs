using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWaveCommand : ICommand
{
    public void Execute()
    {
        App.levelManager.CreateWave();
    }
}
