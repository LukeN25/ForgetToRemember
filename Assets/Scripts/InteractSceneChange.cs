using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractSceneChange : MonoBehaviour
{
    public string scene;
    public bool isNextScene = true;

    [SerializeField] public SceneData sceneData;

    void OnTriggerStay()
    {
        if( Input.GetKeyDown("e")|| Input.GetKeyDown("f"))
        {
            sceneData.isNextScene = isNextScene;
            SceneManager.LoadScene(scene);
        }
    }
}
