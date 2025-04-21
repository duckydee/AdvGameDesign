using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Misc")]
public class MiscClass : ItemClass
{
    // data specific to the misc class
    public override void Use(PlayerTestScript caller)
    {
        //base.Use(caller);   
    }
    public override MiscClass GetMisc() { return this; }
}
