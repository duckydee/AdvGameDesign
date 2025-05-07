using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using System.Threading.Tasks;
public class CollideWithPlayer : MonoBehaviour
{
    [SerializeField] private float damage;
    
    async private void OnTriggerEnter(Collider other)
        {
        if (other.CompareTag("Player"))
        {
                Health player = other.GetComponent<Health>();
                if (player != null) {
                    
                    player.TakeDamage(damage);
                    await Task.Delay(500);
                }
                
            }
            
        }
}
