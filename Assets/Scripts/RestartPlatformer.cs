using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartPlatformer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Player)
    {
        SceneManager.LoadScene("MiniGame 2");
    }
}
