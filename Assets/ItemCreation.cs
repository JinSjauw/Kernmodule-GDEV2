using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCreation : MonoBehaviour
{
    void Start()
    {
        CloneFactory itemMaker = new CloneFactory();

        IItem basicSword = new BaseItem();
        IItem basicShield = new BaseItem();

        IItem clonedSword = new Plain (itemMaker.getClone(basicSword)); 
        IItem clonedShield = new Heavy (itemMaker.getClone(basicShield));
        
        clonedSword = new SwordItem(clonedSword);
        clonedShield = new ShieldItem(clonedShield);

        basicSword = new SwordItem(basicSword);
        basicShield = new ShieldItem(basicShield);

        printItem(basicSword);
        printItem(basicShield);
        printItem(clonedSword);
        printItem(clonedShield);
    }

    void printItem(IItem item) 
    {
        string itemInfo = "";

        itemInfo = "Name: " + item.itemName + " ID: " + item.GetHashCode() + "\n"
            + " Type: " + item.itemType + "\n";

        List<KeyValuePair<string, int>> stats = item.getStats();
        for(int i = 0; i < stats.Count; i++) 
        {
            itemInfo += stats[i].Key + " : " + stats[i].Value + "\n";
        }

        Debug.Log(itemInfo);  
    }
}
