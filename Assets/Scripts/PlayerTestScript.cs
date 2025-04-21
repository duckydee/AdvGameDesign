using UnityEngine;

public class PlayerTestScript : MonoBehaviour
{
    public InventoryManager inventory;
    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.E))
        {
            //use item
            if (inventory.selectedItem != null) 
            {
                inventory.selectedItem.Use(this);
            }
        }
    }

}
