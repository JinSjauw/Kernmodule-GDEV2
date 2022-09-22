using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : IItem
{
    public string getStats() 
    { 
        return "Base Item Stats"; 
    }

    public string getType() 
    { 
        return "Base Item Type"; 
    }
}
