using System.Collections.Generic;

namespace COTL_API.Saves;

internal class APIData
{
    public Dictionary<string, object> data = new();

    internal T GetValue<T>(string key)
    {
        if (data == null)
            data = new();

        if (!data.ContainsKey(key))
            data.Add(key, default(T));

        return data[key] is T res ? res : default(T);
    }

    internal string GetValueAsString(string key)
    {
        return GetValue<string>(key);
    }

    public int GetValueAsInt(string key)
    {
        long value = GetValueAsLong(key);

        if (value > int.MaxValue)
            return int.MaxValue;

        if (value < int.MinValue)
            return int.MinValue;

        return (int)value;
    }

    public long GetValueAsLong(string key)
    {
        return GetValue<long>(key);
    }

    internal float GetValueAsFloat(string key)
    {
        return GetValue<float>(key);
    }

    internal bool GetValueAsBoolean(string key)
    {
        return GetValue<bool>(key);
    }

    internal void SetValue<T>(string key, T value)
    {
        if (data == null)
            data = new();

        if (!data.ContainsKey(key))
            data.Add(key, value);
        else
            data[key] = value;
    }
}