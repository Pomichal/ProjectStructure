using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class RangedUnitModel : UnitBaseModel
{
    public float range;
    public RangedUnitDefinition definition;
    public RangedUnitModel(UnitBaseDefinition definition) : base(definition)
    {
        this.definition = (RangedUnitDefinition)definition;
    }
    public float Damage()
    {
        return definition.damage * damage;
    }
}
