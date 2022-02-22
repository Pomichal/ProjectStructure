using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerModel
{
    public float damage;
    public float attackSpeed;
    public float health;
    public TowerDefinition towerDefinition;

    public TowerModel(TowerDefinition definition)
    {
        this.towerDefinition = definition;
    }
}
