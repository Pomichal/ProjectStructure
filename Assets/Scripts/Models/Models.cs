using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Models
{
    public Player Player { get; set; }
    public TowerFactory TowerFactory { get; private set; }

    public string PlayerDataPath { get; private set; }
    public Models()
    {
        PlayerDataPath = Application.persistentDataPath + "/playerData.json";
        Player = new Player();
        TowerFactory = new TowerFactory();
    }
}
