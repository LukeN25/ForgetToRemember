using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remember : MonoBehaviour
{

    public GameObject Button1;
    public GameObject Button2;
    public GameObject Button3;

    bool nearBed;

    void Start()
    {
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D Player)
    {
        nearBed = true;
    }

    void OnTriggerExit2D(Collider2D Player)
    {
        nearBed = false;
        Button1.SetActive(false);
        Button2.SetActive(false);
        Button3.SetActive(false);
    }
    void Update()
    {
        if (nearBed == true)
        {
            if (Input.GetKeyDown("e"))
            {
                Button1.SetActive(true);
                Button2.SetActive(true);
                Button3.SetActive(true);
            }
        }
        
    }
}
