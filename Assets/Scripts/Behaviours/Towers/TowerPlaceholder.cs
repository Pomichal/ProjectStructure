using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlaceholder : Placable
{
    private BasicTowerModel model;

    public override void Init(TowerModel model)
    {
        this.model = (BasicTowerModel)model;
        waitForSeconds = new WaitForSeconds(this.model.AttackSpeed());
    }
}
