using UnityEngine;
using UnityEngine.SceneManagement;
public class eviIandmysteriouseye : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
        {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Escape");
        }
            
        }
}
