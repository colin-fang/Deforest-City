using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Catalogue : ScriptableObject
{

    public Item currentItem;
    public int locationID;
    public Queue<Item> items = new Queue<Item>();

    public void AddItem(Item itemToAdd)
    {
        items.Enqueue(itemToAdd);
        if(items.Count >= 10)
        {
            items.Dequeue();
        }
    }
    
    

}
