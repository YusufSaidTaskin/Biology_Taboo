using UnityEngine;

public class DiificultyDropdown : MonoBehaviour
{
    public void DifficultyDropdown(int index)
    {
        switch (index)
        {
            case 0: Debug.Log("Kolay"); break;
            case 1: Debug.Log("Orta 1"); break;
            case 2: Debug.Log("Orta 2"); break;
            case 3: Debug.Log("Zor"); break;
            case 4: Debug.Log("Çok Zor"); break;
        }
    }
}