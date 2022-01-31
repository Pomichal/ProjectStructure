using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class WaveDefintion
{
    public List<UnitBaseModel> Units;
    public WaveDefintion()
    {
        Units = new List<UnitBaseModel>{
            {new RangedUnitModel(new UnitBaseDefinition())}
        };
    }
}
