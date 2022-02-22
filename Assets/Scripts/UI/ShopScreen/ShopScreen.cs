using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScreen : ScreenBase
{
    [SerializeField] private Transform contentHolder;
    [SerializeField] private BuildingShopItem shopItemPrefab;
    public override void Show()
    {
        base.Show();
        foreach (Transform item in contentHolder)
        {
            Destroy(item.gameObject);
        }
        foreach (var definition in App.definitions.towers)
        {
            var itemInstance = Instantiate(shopItemPrefab, contentHolder);
            Dictionary<string, object> data = new Dictionary<string, object>
            {
                {"name",definition.Key},
                {"data", definition.Value}
            };
            itemInstance.Init(data);
        }
    }
}
