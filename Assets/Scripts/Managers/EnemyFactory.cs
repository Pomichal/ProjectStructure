using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory
{
    public UnitBaseModel Factory(Enemy type)
    {
        switch (type)
        {
            case Enemy.Archer:
                return new RangedUnitModel(App.definitions.units[Enemy.Archer.ToString()]);
            default:
                throw new System.Exception("This enemy doesn't exist.");
        }
    }
}
