using UnityEngine;

public class GeneratorScript : MonoBehaviour
{
    private bool canBePressed;
    [SerializeField] private InventoryManager inventory;
    [SerializeField] private ItemClass gasoline;
    [SerializeField] private ItemClass key;
    [SerializeField] private GameObject gate;
    [SerializeField] private GameObject door;
    private bool activated;
    public AudioSource genSound;
    public AudioSource doorSound;
    void Update()
    {
        if (gasoline != null)
        {
            if (canBePressed && inventory.selectedItem == gasoline && Input.GetKeyDown(KeyCode.Space))
            {
                inventory.Remove(inventory.selectedItem);
                activated = true;
                Debug.Log("Gas Used, Gate Opened");
                genSound.Play();
                gate.SetActive(false);
            }
        }
        if (key != null) 
        {
            if (canBePressed && inventory.selectedItem == key && Input.GetKeyDown(KeyCode.Space))
            {
                inventory.Remove(inventory.selectedItem);
                activated = true;
                doorSound.Play();
                Debug.Log("key used, door destroyed");
                door.SetActive(false);
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
    public void activate()
    {
        
    }
}
