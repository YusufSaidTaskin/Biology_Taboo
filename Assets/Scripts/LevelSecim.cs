using UnityEngine;

public class LevelSecim : MonoBehaviour
{
    public static LevelSecim Instance;
    public int secilenLevel;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Scene de�i�ince kaybolmas�n
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetLevel(int level)
    {
        secilenLevel = level;
        Debug.Log("Level se�ildi: " + secilenLevel);
    }
}