using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemDecorator : IItem
{
    protected IItem tempItem;

    public ItemDecorator(IItem baseItem) 
    {
        tempItem = baseItem;
    }

    public virtual string getStats() 
    { 
        return tempItem.getStats(); 
    }

    public virtual string getType() 
    {
        return tempItem.getType(); 
    }
}
