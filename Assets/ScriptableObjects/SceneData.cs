using UnityEngine;

[CreateAssetMenu(fileName = "SceneInfo", menuName = "Persistence")]
public class SceneData : ScriptableObject 
{
    public bool isNextScene = true;

    public bool minigame1Complete;
    public bool minigame2Complete;
    public bool minigame3Complete;

    public float posX;
    public float posY;

    public bool hint1;
    public bool hint2;
    public bool hint3;  

    public float plantHealth = 0f;

    void OnEnable()
    {
        minigame1Complete = false;
        minigame2Complete = false;
        minigame3Complete = false;

        posX = 0;
        posY = 0;

        plantHealth = 0f;

        hint1 = false;
        hint2 = false;
        hint3 = false;
    }
}
