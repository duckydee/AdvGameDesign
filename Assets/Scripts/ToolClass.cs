using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Tools")]
public class ToolClass : ItemClass
{
    [Header("Tool")] // data specific to tool class
    public ToolType toolType;

    public enum ToolType
    {
        knife,
        hammer,
        ranged
    }
    public override ItemClass GetItem() { return this; }
    public override ToolClass GetTool() { return this; }
    public override MiscClass GetMisc() { return null; }
    public override ConsumableClass GetConsumable() { return null; }
}
