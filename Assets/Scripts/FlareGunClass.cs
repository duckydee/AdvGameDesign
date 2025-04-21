using UnityEngine;

[CreateAssetMenu(fileName = "new Tool Class", menuName = "Item/Tools/FlareGun")]
public class FlareGunClass : ToolClass
{
    public GameObject flareObject;
    public override void Use(PlayerTestScript caller)
    {
        // base.Use(caller);
        Debug.Log("Fired flare");
        Instantiate(flareObject, caller.transform.position, Quaternion.identity);

    }
}
