using UnityEngine;

[CreateAssetMenu(fileName = "SceneInfo", menuName = "Persistence")]
public class SceneData : ScriptableObject 
{
    public bool isNextScene = true;

    public bool minigame1Complete;
    public bool minigame2Complete;
    public bool minigame3Complete;
    public bool minigame4Complete;

    public float posX;
    public float posY;

    public float plantHealth = 0f;

    void OnEnable()
    {
        minigame1Complete = false;
        minigame2Complete = false;
        minigame3Complete = false;
        minigame4Complete = false;

        posX = 0;
        posY = 0;

        plantHealth = 0f;
    }
}
