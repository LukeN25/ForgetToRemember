using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintEnabler : MonoBehaviour
{

    public GameObject Hint1;
    public GameObject Hint2;

    public SceneData sceneData;

    
    // Update is called once per frame
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

        if (Input.GetKeyDown("e"))
        {
            sceneData.hint1 = false;
            sceneData.hint2 = false;
            Hint1.SetActive(false);
            Hint2.SetActive(false);
        }
    }
}
