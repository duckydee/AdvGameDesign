using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] public float playerHealth;

    public AudioSource hurtSound;

    public void TakeHealing(float heal)
    {
        playerHealth += heal;
        Debug.Log("Player health: " + playerHealth);
        if(playerHealth > 100)
        {
            playerHealth = 100;
        }
    }
    public void TakeDamage(float damage)
    {
        playerHealth-= damage;
        hurtSound.Play();
        Debug.Log("Player health: "+ playerHealth);
        if (playerHealth <= 0){
            //Switch to game over screen
            SceneManager.LoadScene("GameOver");
        }
    }
}