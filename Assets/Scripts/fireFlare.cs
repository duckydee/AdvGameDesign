using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using UnityEngine;

public class fireFlare : MonoBehaviour
{
    public Transform flare;
    public Transform slash;
    public Transform unlock;
    [SerializeField] InventoryManager inventory;
    [SerializeField] ItemClass flareGun;
    [SerializeField] ItemClass knife;
    [SerializeField] ItemClass key;
    [SerializeField] ItemClass syringe;
    [SerializeField] Health health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flare = GameObject.FindGameObjectWithTag("flare").transform;
        slash = GameObject.FindGameObjectWithTag("slash").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.selectedItem == flareGun)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(flare, transform.position, transform.rotation);
                inventory.Remove(inventory.selectedItem);
            }
        }
        if (inventory.selectedItem == knife)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(slash, transform.position, transform.rotation);
            }
        }
        if (inventory.selectedItem == syringe)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                health.TakeHealing(50);
                inventory.Remove(inventory.selectedItem);
            }
        }
    }
}
