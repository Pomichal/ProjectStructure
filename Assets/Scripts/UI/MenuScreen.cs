using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : ScreenBase
{
    public void StartGame()
    {
        App.gameManager.StartGame();
        Hide();
    }
}
