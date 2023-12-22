using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public SceneData sceneData;

    public bool minigame1Complete;
    public bool minigame2Complete;
    public bool minigame3Complete;

    public GameObject Minigame1;
    public GameObject Minigame2;
    public GameObject Minigame3;


    void Update()
    {
        minigame1Complete = sceneData.minigame1Complete;
        minigame2Complete = sceneData.minigame2Complete;
        minigame3Complete = sceneData.minigame3Complete;

        if (minigame1Complete == true)
        {
            Minigame1.SetActive(false);
        }

        if (minigame2Complete == true)
        {
            Minigame2.SetActive(false);
        }

        if (minigame3Complete == true)
        {
            Minigame3.SetActive(false);
        }
    }
}
