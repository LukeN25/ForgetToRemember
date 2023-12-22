using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintEnabler : MonoBehaviour
{

    public GameObject Hint1;
    public GameObject Hint2;
    public GameObject Hint3;

    public SceneData sceneData;

    void Update()
    {
        if(sceneData.hint1 == true)
        {
            Hint1.SetActive(true);
        }

        if (sceneData.hint2 == true)
        {
            Hint2.SetActive(true);
        }

        if (sceneData.hint3 == true)
        {
            Hint3.SetActive(true);
        }

        if (Input.GetKeyDown("e"))
        {
            sceneData.hint1 = false;
            sceneData.hint2 = false;
            sceneData.hint3 = false;
            Hint1.SetActive(false);
            Hint2.SetActive(false);
            Hint3.SetActive(false);
        }
    }
}
