using System.Collections;
using UnityEngine;

public class ItemClass : ScriptableObject
{
    [Header("Tool")] // data shared across ever item
    public int itemID;
    public string itemName;
    public Sprite itemIcon;
    public bool isStackable = true;
    public Object Model;

    public virtual void Use(PlayerTestScript caller)
    {
        Debug.Log("Used Item");
    }
    public virtual void Drop(PlayerTestScript caller)
    {
        Debug.Log("Item Dropped");
    }
    public virtual ItemClass GetItem()
    {
        return this;
    }
    public virtual ToolClass GetTool()
    {
        return null;
    }
    public virtual MiscClass GetMisc()
    { 
        return null; 
    }
    public virtual ConsumableClass GetConsumable()
    {
        return null;
    }
}
