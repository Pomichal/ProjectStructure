using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTowerModel : TowerModel
{
    private BasicTower definition;
    public BasicTowerModel(TowerDefinition definition) : base(definition)
    {
        this.definition = (BasicTower)towerDefinition;
    }
    public int Damage()
    {
        return (int)(damage * definition.damage);
    }
}
