using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordItem : ItemDecorator
{
    public SwordItem(IItem baseItem) : base(baseItem)
    {
        Debug.Log("Making it a Sword!");
        Debug.Log("Adding damage!");
    }

    public override string getStats()
    {
        return base.getStats() + "Scrap that, +10 ATK +2 REACH";
    }

    public override string getType()
    {
        return base.getType() + "It's a Sword now";
    }
}
