using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int coins;
    private int currentLevel;
    public int GetCoins()
    {
        return coins;
    }
    public void SetCoins(int amount)
    {
        coins += amount;
    }
}
