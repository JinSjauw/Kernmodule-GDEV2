using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    WEAPON,
    SHIELD,
    ACCESSORY,
    CONSUMABLE
}

public interface IItem : IPrototype<IItem>
{
    public ItemType itemType 
    { 
        get; 
        set;
    }
    public string itemName 
    {
        get;
        set;
    }
    public void addStat(string statName, int value);
    public List<KeyValuePair<string, int>> getStats();
}
