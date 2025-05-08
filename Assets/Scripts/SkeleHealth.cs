using UnityEngine;

public class SkeleHealth : MonoBehaviour
{
    [SerializeField] public float playerHealth;

    public AudioSource hurtSound;

    public void TakeDamage(float damage)
    {
        playerHealth-= damage;
        hurtSound.Play();
        Debug.Log("Enemey health: "+ playerHealth);
    }
}
