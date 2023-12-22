using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public SceneData sceneData;

    public bool minigame1Complete;
    public bool minigame2Complete;
    public bool minigame3Complete;
    public bool minigame4Complete;

    public GameObject Minigame1;
    public GameObject Minigame2;
    public GameObject Minigame3;
    public GameObject Minigame4;


    void Update()
    {
        minigame1Complete = sceneData.minigame1Complete;
        minigame2Complete = sceneData.minigame2Complete;
        minigame3Complete = sceneData.minigame3Complete;
        minigame4Complete = sceneData.minigame4Complete;

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

        if (minigame4Complete == true)
        {
            Minigame4.SetActive(false);
        }
    }
}
