using UnityEngine;



public class ItemData : ScriptableObject
{
    public string itemName;
    public Sprite icon;
    public GameObject model;
    [TextArea]
    public string description;

    public int startingAmmo;
    public int startingCondition;
}

