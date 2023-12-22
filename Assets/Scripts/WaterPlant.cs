using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlant : MonoBehaviour
{
    public GameObject UICanvas;
    public SceneData sceneData;

    public GameObject Healthy;
    public GameObject NotHealthy;
    public GameObject Dead;

    bool canBeWatered;

    void OnTriggerEnter2D(Collider2D Player)
    {
        UICanvas.SetActive(true);
        canBeWatered = true;
    }

    void Update()
    {
        if (canBeWatered == true)
        {
            if (Input.GetKeyDown("e"))
            {
                sceneData.plantHealth = 0;
                canBeWatered = false;
            }
        }

        if (sceneData.plantHealth == 0) 
        {
            Healthy.SetActive(true);
            NotHealthy.SetActive(false);
            Dead.SetActive(false);
        }

        if (sceneData.plantHealth == 1)
        {
            Healthy.SetActive(false);
            NotHealthy.SetActive(true);
            Dead.SetActive(false);
        }

        if (sceneData.plantHealth >= 2)
        {
            Healthy.SetActive(false);
            NotHealthy.SetActive(false);
            Dead.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D Player)
    {
        UICanvas.SetActive(false);
        canBeWatered = false;
    }
}
