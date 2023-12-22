using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPlatformer : MonoBehaviour
{
    public SceneData sceneData;

    void OnTriggerEnter2D(Collider2D Player)
    {
        SceneManager.LoadScene("Gameplay");
        sceneData.minigame2Complete = true;
        sceneData.hint2 = true;
    }
}
