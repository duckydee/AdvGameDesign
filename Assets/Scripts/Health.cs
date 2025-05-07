using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float playerHealth;


    public void TakeDamage(float damage)
    {
        playerHealth-= damage;
        Debug.Log("Player health: "+ playerHealth);
    }
}