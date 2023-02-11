using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class MyUnityEventScript : MonoBehaviour
{
    public static event Action onGameOver;
    public UnityEvent onDeath;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Enemy")
        {
            onDeath.Invoke();
          
        }        
    }
}
