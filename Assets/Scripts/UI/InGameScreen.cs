using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameScreen : ScreenBase
{

    public override void Show()
    {
        base.Show();
        App.musicManager.SetMusic(Music.InGame);
    }

    public void ReturnToMenu()
    {
        App.gameManager.ReturnToMenu();
        Hide();
    }

}
