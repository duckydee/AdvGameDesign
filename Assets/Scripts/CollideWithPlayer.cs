using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class CollideWithPlayer : MonoBehaviour
{
    public UnityEvent UnityEvent;
    public GameObject theTrigger;
    
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject == theTrigger)
        {
            UnityEvent.Invoke();
            //Destroy(theTrigger.gameObject);
        }
    }
}
