using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum UnitTypes
{
    Ranged, Melee
}
public class Definitions
{
    public Dictionary<UnitTypes, List<UnitBaseDefinition>> units = new Dictionary<UnitTypes, List<UnitBaseDefinition>>();
    public Definitions()
    {
        App.definitions = this;
        LoadUnitDefintions();
    }
    private void LoadUnitDefintions()
    {
        units[UnitTypes.Ranged] = Resources.LoadAll<UnitBaseDefinition>("Units/Ranged").ToList();
        units[UnitTypes.Melee] = Resources.LoadAll<UnitBaseDefinition>("Units/Melee").ToList();
    }
}
