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
    public override void Use(PlayerTestScript caller)
    {
        base.Use(caller);
        Debug.Log("Swing sword");
    }
    public override ToolClass GetTool() { return this; }
}
