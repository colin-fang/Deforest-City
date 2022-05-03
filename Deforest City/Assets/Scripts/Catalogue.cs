using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

[CreateAssetMenu]
public class Catalogue : ScriptableObject
{

    public Item currentItem;
    public int locationID;
    public int stage;
    public Queue<Item> items = new Queue<Item>();

    public void AddItem(Item itemToAdd)
    {
        items.Enqueue(itemToAdd);
        Debug.Log("add item " + items.Count);
        if(items.Count >= 10)
        {
            items.Dequeue();
            Destroy(PlantSeed.treeAdded.Dequeue());
        }
    }
}
