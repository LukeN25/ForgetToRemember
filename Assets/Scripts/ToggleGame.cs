using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToggleGame : MonoBehaviour
{
    [SerializeField] string sceneToLoad;

    void OnTriggerStay2D()
    {
        if (Input.GetKeyDown("e"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
