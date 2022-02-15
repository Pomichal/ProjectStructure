using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory
{
    public TowerModel Factory(TowerDefinition definition)
    {
        switch (definition)
        {
            case BasicTower tower:
                return new BasicTowerModel(tower);
            default:
                throw new System.Exception("This enemy doesn't exist.");
        }
    }
}
