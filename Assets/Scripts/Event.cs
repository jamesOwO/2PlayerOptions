using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public static Event current;

    private void Awake()
    {
        current = this; 
    }

    public event Action onLiftTriggerEnter;
    
        
    public void LiftTriggerEnter()
    {
        if (onLiftTriggerEnter != null)
        {
            onLiftTriggerEnter();
        }
    }

}
