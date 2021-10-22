using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    private readonly Dictionary<string, object> data = new Dictionary<string, object>();

    public static GameData Instance;

    private GameData() { }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetValue(string valueName, object value)
    {
        if (data.ContainsKey(valueName))
        {
            data[valueName] = value;
        } 
        else
        {
            data.Add(valueName, value);
        }
    }

    public bool TryGetValue(string valueName, out object value)
    {
        return data.TryGetValue(valueName, out value);
    }
}
