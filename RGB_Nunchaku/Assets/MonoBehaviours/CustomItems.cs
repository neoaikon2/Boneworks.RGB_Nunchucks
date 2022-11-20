using StressLevelZero.Data;
using StressLevelZero.Pool;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Put this on the CustomItems gameobject.
/// </summary>
[RequireComponent(typeof(LocalizedText))]
public class CustomItems : MonoBehaviour
{
    public ItemSettings settings;


    [System.Serializable]
    public class ItemSettings
    {
        public string author;
        public List<Item> items = new List<Item>();

        [System.Serializable]
        public class Item
        {
            public string name;
            public CategoryFilters category;
            public PoolMode poolMode;
            public int pooledAmount;
            public bool hideInMenu;
        }
    }
}
