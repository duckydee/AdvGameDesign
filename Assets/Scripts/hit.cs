using UnityEngine;

public class hit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("hitbox"))
    {
        Debug.Log("THIS IS A TEST, IT COLLIDED");
    }
    }
}
