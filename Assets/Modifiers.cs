using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plain : ItemDecorator
{
    public Plain(IItem baseitem) : base(baseitem) 
    {
        baseitem.itemName = "Plain" + " " + baseitem.itemName;
        baseitem.addStat("Boring", 100);
    }
}

public class Sharp : ItemDecorator
{
    public Sharp(IItem baseitem) : base(baseitem)
    {
        baseitem.itemName = "Sharp" + " " + baseitem.itemName;
        baseitem.addStat("Penetration", 15);
    }
}

public class Light : ItemDecorator
{
    public Light(IItem baseitem) : base(baseitem)
    {
        baseitem.itemName = "Light" + " " + baseitem.itemName;
        baseitem.addStat("Weight", -3);
    }
}

public class Heavy : ItemDecorator
{
    public Heavy(IItem baseitem) : base(baseitem)
    {
        baseitem.itemName = "Heavy" + " " + baseitem.itemName;
        baseitem.addStat("Weight", 3);
    }
}
