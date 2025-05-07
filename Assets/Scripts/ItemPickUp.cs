using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    [SerializeField] private ItemClass Item;
    [SerializeField] private Rigidbody itemCollision;
    [SerializeField] private Rigidbody playerCollision;
    [SerializeField] private InventoryManager inventoryManager;

    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            Debug.Log("touching Item");
            if (Item != null) 
            {
                //Physics.OverlapBox()
                //inventoryManager.Add(Item, 1);
            }
        }
    }

    private void Update()
    {
        if (itemCollision != null) { }
    }

}
