using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFactory : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        IItem basicSword = new SwordItem(new BaseItem());
        IItem basicShield = new ShieldItem(new BaseItem());

        Debug.Log("Sword: " + basicSword.getStats() + " Type:" + basicSword.getType());
        Debug.Log("Shield: " + basicShield.getStats() + " Type:" + basicShield.getType());
    }
}
