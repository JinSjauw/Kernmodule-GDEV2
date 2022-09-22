using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldItem : ItemDecorator
{
    public ShieldItem(IItem baseItem) : base(baseItem)
    {
        Debug.Log("Making it a Shield!");
        Debug.Log("Adding defense!");
    }

    public override string getStats()
    {
        return base.getStats() + " Scrap that, +10 DEF +10 PhysRES";
    }

    public override string getType()
    {
        return base.getType() + " It's a Shield now!";
    }
}
