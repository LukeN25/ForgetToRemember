using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToggleGame : MonoBehaviour
{
    [SerializeField] string sceneToLoad;
    bool enterGame1 = false;

    void OnTriggerEnter2D()
    {
        enterGame1 = true;
    }

    void OnTriggerExit2D()
    {
        enterGame1 = false;
    }

    void Update()
    {
        if (enterGame1 == true)
        {
            if (Input.GetKeyDown("e"))
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
