using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Event.current.onLiftTriggerEnter += OnLiftOpen;
    }
    private void OnLiftOpen()
    {
        LeanTween.moveLocalY(gameObject, 1.6f, 1f).setEaseOutQuad();
    }
}
