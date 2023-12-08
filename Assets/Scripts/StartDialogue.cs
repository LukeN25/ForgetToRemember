using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDialogue : MonoBehaviour
{
    public GameObject button;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            button.SetActive(true);
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            button.SetActive(false);
        }
    }
}
