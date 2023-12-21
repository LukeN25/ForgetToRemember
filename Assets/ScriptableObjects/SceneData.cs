using UnityEngine;

[CreateAssetMenu(fileName = "SceneInfo", menuName = "Persistence")]
public class SceneData : ScriptableObject 
{
    public bool isNextScene = true;

    void OnEnable()
    {
        //default data
    }
}
