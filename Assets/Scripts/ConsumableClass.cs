using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Consumable")]
public class ConsumableClass : ItemClass
{
    [Header("Consumable")] // data specific to consumable class
    public float healthAdded;
    public override void Use(PlayerTestScript caller)
    {
        base.Use(caller);
        Debug.Log("Eat consumable");
        //caller.inventory.ConsumeSelected();
        caller.inventory.Remove(this);
    }
    public override ConsumableClass GetConsumable() { return this; }
}
