using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionScript : MonoBehaviour
{
    public UnityEvent enteredInteraction, exitedInteraction, interacted;
    private bool interactionEnabled;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            enteredInteraction.Invoke();
            interactionEnabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            exitedInteraction.Invoke();
            interactionEnabled = false;
        }
    }

    void Update()
    {
        if (interactionEnabled && Input.GetKeyDown(KeyCode.E))
        {
            exitedInteraction.Invoke();
            interacted.Invoke();
        }
    }
}
