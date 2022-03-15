using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : ScreenBase
{

    public override void Show()
    {
        base.Show();
        App.musicManager.SetMusic(Music.Menu);
    }

    public void StartGame()
    {
        App.soundManager.PlaySound(0, Vector3.zero);
        App.gameManager.StartGame();
        Hide();
    }
}
