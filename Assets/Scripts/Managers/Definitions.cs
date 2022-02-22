using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class Definitions
{
    public Dictionary<string, UnitBaseDefinition> units = new Dictionary<string, UnitBaseDefinition>();
    public List<LevelDefinition> levels = new List<LevelDefinition>();
    public Dictionary<string, TowerDefinition> towers = new Dictionary<string, TowerDefinition>();
    public Definitions()
    {
        App.definitions = this;
        LoadUnitDefintions();
        LoadLevelDefintions();
        LoadTowerDefinitions();
    }
    private void LoadUnitDefintions()
    {
        UnitBaseDefinition[] unitsArray = Resources.LoadAll<UnitBaseDefinition>("Units");
        foreach (UnitBaseDefinition unit in unitsArray)
        {
            units.Add(unit.name, unit);
        }
    }
    private void LoadLevelDefintions()
    {
        levels = Resources.LoadAll<LevelDefinition>("Levels").ToList();
    }
    private void LoadTowerDefinitions()
    {
        TowerDefinition[] towersArray = Resources.LoadAll<TowerDefinition>("Towers");
        foreach (TowerDefinition tower in towersArray)
        {
            towers.Add(tower.name, tower);
        }
    }
}
