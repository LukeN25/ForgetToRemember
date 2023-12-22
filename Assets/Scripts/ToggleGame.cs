using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToggleGame : MonoBehaviour
{
    [SerializeField] string sceneToLoad;
    bool enterGame = false;

    public bool isNextScene = true;
    [SerializeField] public SceneData sceneData;

    public Transform playerPosition;

    void OnTriggerEnter2D()
    {
        enterGame = true;
    }

    void OnTriggerExit2D()
    {
        enterGame = false;
    }

    void Update()
    {
        if (enterGame == true)
        {
            if (Input.GetKeyDown("e"))
            {
                sceneData.isNextScene = isNextScene;
                SceneManager.LoadScene(sceneToLoad);
                sceneData.posX = playerPosition.position.x;
                sceneData.posY = playerPosition.position.y;
            }
        }
    }
}
