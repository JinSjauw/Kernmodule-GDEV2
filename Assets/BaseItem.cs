using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : IItem
{

    ItemType _itemType;
    ItemType IItem.itemType 
    {
        get => _itemType;
        set => _itemType = value;
    }

    string _itemName;
    string IItem.itemName 
    {
        get => _itemName;
        set => _itemName = value;
    }

    List<KeyValuePair<string, int>> statList;

    public BaseItem() 
    {
        statList = new List<KeyValuePair<string, int>>();
    }

    public void addStat(string statName, int value) 
    {
        statList.Add(new KeyValuePair<string, int>(statName, value));
    }

    public List<KeyValuePair<string, int>> getStats() 
    { 
        return statList; 
    }

    public IItem CreateDeepCopy() 
    {
        return (IItem)base.MemberwiseClone();
    }
}
