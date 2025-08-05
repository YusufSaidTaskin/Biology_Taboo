using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneControl : MonoBehaviour
{
    public void GoToPlayScene()
    {
        SceneManager.LoadSceneAsync("Oyun");
    }

    public void GoToMenuScene()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
}
