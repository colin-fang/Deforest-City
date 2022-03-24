using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Database", menuName = "CustomSO/ItemDatabase")]
public class Database : ScriptableObject
{
    [System.Serializable]
    public struct ItemData
    {
        public Item item;
        public string name;
    }

    public List<ItemData> allEntities;
}