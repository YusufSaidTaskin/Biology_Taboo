using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiificultyDropdown : MonoBehaviour
{
    public void DifficultyDropdown(int index)
    {
        switch (index)
        {
            case 0: Debug.Log("Kolay");
                FindAnyObjectByType<LevelSecim>().secilenLevel = 1;
                break;
            case 1: Debug.Log("Orta 1");
                FindAnyObjectByType<LevelSecim>().secilenLevel = 2;
                break;
            case 2: Debug.Log("Orta 2");
                FindAnyObjectByType<LevelSecim>().secilenLevel = 3;
                break;
            case 3: Debug.Log("Zor");
                FindAnyObjectByType<LevelSecim>().secilenLevel = 4;
                break;
            case 4: Debug.Log("Çok Zor");
                FindAnyObjectByType<LevelSecim>().secilenLevel = 5;
                break;
        }
    }
    public TMP_Dropdown dropdown;

    public void LevelSecildi()
    {
        int level = dropdown.value + 1;
        LevelSecim.Instance.SetLevel(level); // Seçilen level’i sakla
    }
}