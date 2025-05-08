using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] public float playerHealth;

    public AudioSource hurtSound;

    public void TakeDamage(float damage)
    {
        playerHealth-= damage;
        hurtSound.Play();
        Debug.Log("Player health: "+ playerHealth);
    }
}