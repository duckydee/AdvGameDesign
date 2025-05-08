using UnityEngine;

public class GeneratorScript : MonoBehaviour
{
    private bool canBePressed;
    [SerializeField] private InventoryManager inventory;
    [SerializeField] private ItemClass gasoline;
    [SerializeField] private GameObject gate;
    private bool activated;
    void Update()
    {
        if(canBePressed && inventory.selectedItem == gasoline && Input.GetKeyDown(KeyCode.E))
        {
            inventory.Remove(inventory.selectedItem);
            activated = true;
            Debug.Log("Gas Used, Gate Opened");
            gate.SetActive(false);
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
    public void activate()
    {
        
    }
}
