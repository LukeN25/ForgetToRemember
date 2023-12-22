using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerStatus : MonoBehaviour
{
    public SceneData sceneData;

    public GameObject flowerHealthy;
    public GameObject flowerDead;

    void Update()
    {
        if(sceneData.plantHealth == 0)
        {
            flowerDead.SetActive(false);
            flowerHealthy.SetActive(true);
        }

        if (sceneData.plantHealth >= 1)
        {
            flowerDead.SetActive(true);
            flowerHealthy.SetActive(false);
        }
    }
}
