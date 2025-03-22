using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Inventory/item features created with the help of ErenCode tutorials
    public ItemClass itemToAdd;
    public ItemClass itemToRemove;

    public List<ItemClass> items = new List<ItemClass>();

    // This happens as soon as the game starts, meaning that it's just a test feature and will need to be removed in the future
    public void Start()
    {
        Add(itemToAdd);
        Remove(itemToRemove);
    }

    public void Add(ItemClass item)
    {
        items.Add(item);
    }

    public void Remove(ItemClass item)
    {
        items.Remove(item);
    }
}
