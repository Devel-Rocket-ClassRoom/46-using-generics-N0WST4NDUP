using System;
using System.Collections.Generic;

public class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    private TKey[] _keys;
    private TValue[] _values;
    private int _count;
    public int Count => _count;

    public Registry(int cap)
    {
        _keys = new TKey[cap];
        _values = new TValue[cap];
    }

    public void Register(TKey key, TValue value)
    {
        if (Contains(key))
        {
            for (int i = 0; i < _count; i++)
            {
                if (_keys[i].Equals(key))
                {
                    _values[i] = value;
                    return;
                }
            }
        }

        if (_count > _keys.Length - 1) return;

        _keys[_count] = key;
        _values[_count] = value;
        _count++;
    }

    public TValue Find(TKey key)
    {
        TValue result = default(TValue);
        for (int i = 0; i < _count; i++)
        {
            if (_keys[i].Equals(key))
            {
                result = _values[i];
                break;
            }
        }
        return result;
    }

    public bool Contains(TKey key)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_keys[i].Equals(key)) return true;
        }
        return false;
    }

    public void PrintAll()
    {
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine($"[{_keys[i]}] {_values[i]}");
        }
    }
}