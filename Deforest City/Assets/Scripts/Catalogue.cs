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
        items.Add(itemToAdd);
       /* if (!items.Contains(itemToAdd))
        {
            items.Add(itemToAdd);
        }       */
    }
    
    public void RemoveItem(Item itemToRemove)
    {
        if (items.Contains(itemToRemove))
        {
            items.Remove(itemToRemove);
        }
    }
    public Item GetItem(string name)
    {
        for (int i = 0; i < items.Count; i++)
        {
            // Debug.Log("loop" + items[i].GetName());
            if(items[i].GetName() == name)
            {
                // Debug.Log("Catalogue" + items[i].GetName());
                return items[i];
            }
        }
        return null;
    }
}
