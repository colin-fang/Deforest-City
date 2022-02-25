using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{

    public GameObject itemObject;
    public string itemName;
    public bool isPlant;

    public string GetName()
    {
        return itemName;
    }

}
