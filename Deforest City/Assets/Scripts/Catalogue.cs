using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Catalogue : ScriptableObject
{

    public Item currentItem;
    public List<Item> items = new List<Item>();

    public void AddItem(Item itemToAdd)
    {        
        if (!items.Contains(itemToAdd))
        {
            items.Add(itemToAdd);
        }       
    }

}
