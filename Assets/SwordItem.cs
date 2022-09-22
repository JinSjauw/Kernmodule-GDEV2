using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordItem : ItemDecorator
{
    public SwordItem(IItem baseItem) : base(baseItem)
    {
        baseItem.itemType = ItemType.WEAPON;
        baseItem.itemName = baseItem.itemName + " " + "Sword";
        baseItem.addStat("ATK", 15);
        baseItem.addStat("REACH", 3);
    }

    public override List<KeyValuePair<string, int>> getStats()
    {
        return base.getStats();
    }
}
