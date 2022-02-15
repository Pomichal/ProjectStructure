using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Models
{
    public Player Player { get; private set; }
    public TowerFactory TowerFactory { get; private set; }
    public Models()
    {
        Player = new Player();
        TowerFactory = new TowerFactory();
    }
}
