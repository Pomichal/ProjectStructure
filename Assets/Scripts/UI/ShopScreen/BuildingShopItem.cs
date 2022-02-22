using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildingShopItem : MenuItem
{
    [SerializeField] private TextMeshProUGUI nameText;
    public override void Init(Dictionary<string, object> data)
    {
        base.Init(data);
        nameText.text = (string)data["name"];
    }
    public void Buy()
    {
        TowerModel model = App.models.TowerFactory.Factory((TowerDefinition)data["data"]);
        Placable instance = Instantiate(model.towerDefinition.prefab);
        instance.Init(model);
    }
}
