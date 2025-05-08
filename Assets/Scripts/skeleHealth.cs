using UnityEngine;

public class skeleHealth : MonoBehaviour
{
    [SerializeField] public float enemyHealth;

    public AudioSource hurtSound;

    public void TakeDamage(float damage)
    {
        enemyHealth-= damage;
        hurtSound.Play();
        Debug.Log("Enemey health: "+ enemyHealth);
    }
}
