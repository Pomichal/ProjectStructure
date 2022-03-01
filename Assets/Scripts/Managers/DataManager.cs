using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    private void Awake()
    {
        App.dataManager = this;
        App.models.Player = LoadData<Player>();
    }
    public void SaveData()
    {
        JsonDataParser.WriteJson(App.models.Player, App.models.PlayerDataPath);
    }
    public T LoadData<T>()
    {
        return JsonDataParser.LoadJson<T>(App.models.PlayerDataPath);
    }
}
