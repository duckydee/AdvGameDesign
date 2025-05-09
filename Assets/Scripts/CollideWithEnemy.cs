using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using System.Threading.Tasks;
public class CollideWithEnemy : MonoBehaviour
{
    [SerializeField] private float damage;
    Rigidbody m_Rigidbody;
    
    async private void OnTriggerEnter(Collider other)
        {
            m_Rigidbody = GetComponent<Rigidbody>();
        if (other.CompareTag("enemy"))
        {
                skeleHealth enemy = other.GetComponent<skeleHealth>();
                if (enemy != null) {
                    
                    enemy.TakeDamage(damage);
                    Destroy(this.gameObject);
                }
                
        }
        else if (this.CompareTag("flare")) {
            m_Rigidbody.linearVelocity = transform.forward * 10;
            Destroy(this.gameObject, 20f);
            if (other.CompareTag("Untagged")){
                 Destroy(this.gameObject);
            }
        }
        else if (this.CompareTag("slash"))
        {
            m_Rigidbody.linearVelocity = transform.forward * 10;
            Destroy(this.gameObject, 0.1f);
            if (other.CompareTag("Untagged"))
            {
                Destroy(this.gameObject);
            }
        }
        else if (this.CompareTag("Unlock"))
        {
            m_Rigidbody.linearVelocity = transform.forward * 10;
            Destroy(this.gameObject, 1f);
            if (other.CompareTag("Untagged"))
            {
                other.gameObject.SetActive(false);
                Destroy(this.gameObject);
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
        }
}
