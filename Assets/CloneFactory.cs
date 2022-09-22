using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneFactory
{
    public IItem getClone(IItem itemSample) 
    {
        return (IItem)itemSample.CreateDeepCopy();
    }

    public IItem getClone(ItemDecorator itemSample) 
    {
        return itemSample.CreateDeepCopy();
    }
}
