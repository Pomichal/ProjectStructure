using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveSetupScreen : ScreenBase
{
    [SerializeField] private Button waveButton;
    public void StartWave()
    {
        new StartWaveCommand().Execute();
        Hide();
    }
}
