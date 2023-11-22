using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractSceneChange : MonoBehaviour
{
    public string scene;

    void OnTriggerStay()
    {
        if( Input.GetKeyDown("e")|| Input.GetKeyDown("f"))
        {
            SceneManager.LoadScene(scene);
        }
    }
}
