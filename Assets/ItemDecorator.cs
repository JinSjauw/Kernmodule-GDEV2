using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemDecorator : IItem
{
    public IItem tempItem;
    
    ItemType IItem.itemType
    {
        get => tempItem.itemType;
        set => tempItem.itemType = value;
    }

    string IItem.itemName 
    {
        get => tempItem.itemName;
        set => tempItem.itemName = value;
    }

    public ItemDecorator(IItem baseItem)
    {
        tempItem = baseItem;
    }

    public void addStat(string statName, int value)
    {
        tempItem.addStat(statName, value);
    }

    public virtual List<KeyValuePair<string, int>> getStats() 
    { 
        return tempItem.getStats(); 
    }

    public object Clone()
    {
        return (IItem)this.MemberwiseClone();
    }

    public IItem CreateDeepCopy()
    {
        return (IItem)MemberwiseClone();
    }
}
