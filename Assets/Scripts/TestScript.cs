using UnityEngine;

public class testScript : MonoBehaviour
{
    [SerializeField] private float damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Health player = other.GetComponent<Health>();
            player.TakeDamage(damage);
        }
    }
}

