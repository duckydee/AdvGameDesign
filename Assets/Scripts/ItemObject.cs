using UnityEngine;

public class ItemObject : MonoBehaviour
{
    [SerializeField] private ItemClass item;
    [SerializeField] private InventoryManager inventory;
    [SerializeField] public GameObject selfReference;
    private bool canBePressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            if (canBePressed)
            {
                inventory.pickUp(item);
                // This is a bit of a nightmare solution, but an item only get's it's self reference when it is picked up
                item.selfReference = selfReference;
                gameObject.SetActive(false);
            }
 
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pickUp")
        {
            canBePressed = true;
            Debug.Log("Entered trigger zone");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "pickUp")
        {
            canBePressed = false;
            Debug.Log("Left trigger zone");
        }

        //gameObject.SetActive(false);
    }
}
