using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleList : MonoBehaviour
{
    public GameObject ListCanvas;
    public GameObject UICanvas;


    void OnTriggerEnter2D()
    {
        UICanvas.SetActive(true);
    }

    void OnTriggerStay2D()
    {
        if (Input.GetKey("e"))
        {
            ListCanvas.SetActive(true);
        }
        
    }
    void OnTriggerExit2D() 
    { 
        ListCanvas.SetActive(false);
        UICanvas.SetActive(false);
    }

}
