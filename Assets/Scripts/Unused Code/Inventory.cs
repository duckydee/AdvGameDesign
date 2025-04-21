using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemInstance> items = new();

    public void AddItem(ItemInstance itemToAdd)
    {
        items.Add(itemToAdd);
    }

    public void RemoveItem(ItemInstance itemToRemove)
    {
        items.Remove(itemToRemove);
    }
}

public class DynamicInventory : ScriptableObject
{
    public int maxItems = 2;
    public List<ItemInstance> items = new();

    public bool AddItem(ItemInstance itemToAdd)
    {
        // Finds an empty slot if there is one
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                return true;
            }
        }

        // Adds a new item if the inventory has space
        if (items.Count < maxItems)
        {
            items.Add(itemToAdd);
            return true;
        }

        Debug.Log("No space in the inventory");
        return false;
    }
}

[System.Serializable]
public class ItemInstance
{
    public ItemData itemType;
    public int condition;
    public int ammo;
    public ItemData newItemType;
    public List<ItemInstance> items = new();

    void Start()
    {
        items.Add(new ItemInstance(newItemType));
    }

    public ItemInstance(ItemData itemData)
    {
        itemType = itemData;
        condition = itemData.startingCondition;
        ammo = itemData.startingAmmo;
    }
}

