using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldItem : ItemDecorator
{
    public ShieldItem(IItem baseItem) : base(baseItem)
    {
        baseItem.itemType = ItemType.SHIELD;
        baseItem.itemName = baseItem.itemName + " " + "Shield";
        baseItem.addStat("DEF", 12);
        baseItem.addStat("PHYSRES", 5);
    }
}
