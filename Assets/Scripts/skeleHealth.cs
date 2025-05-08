using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

public class skeleHealth : MonoBehaviour
{
    [SerializeField] public float enemyHealth;
    public Vector3 grave;

    public AudioSource hurtSound;
    private Animator skeleAnim;
    public async void TakeDamage(float damage)
    {
        enemyHealth-= damage;
        hurtSound.Play();
        Debug.Log("Enemey health: "+ enemyHealth);
        if (enemyHealth <= 0){
            skeleAnim = GetComponent<Animator>();
            Destroy(this.gameObject.GetComponent<FollowPath>());
            skeleAnim.SetTrigger("death");
            await Task.Delay(2000);
            Destroy(this.gameObject);
        }
    }
}
