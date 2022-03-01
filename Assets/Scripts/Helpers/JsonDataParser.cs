using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
public static class JsonDataParser
{
    public static void WriteJson(object obj, string path)
    {
        string json = JsonConvert.SerializeObject(obj);
        try
        {
            File.WriteAllText(path, json);
        }
        catch (Exception exception)
        {
            Debug.LogError(exception);
        }
    }
    public static T LoadJson<T>(string path)
    {
        try
        {
            StreamReader reader = new StreamReader(path);
            string json = reader.ReadToEnd();
            reader.Close();
            return JsonConvert.DeserializeObject<T>(json);
        }
        catch (Exception exception)
        {
            Debug.LogError(exception);
            return default;
        }
    }
}
