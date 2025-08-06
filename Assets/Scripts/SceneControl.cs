using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneControl : MonoBehaviour
{
    public GameObject panel;
    private void Start()
    {
        panel.SetActive(false);
    }
    public void GoToPlayScene()
    {
        SceneManager.LoadSceneAsync("Oyun");
        PlayerPrefs.DeleteKey("PlayerScore");
        PlayerPrefs.DeleteKey("GameTime");
    }

    public void GoToMenuScene()
    {
        SceneManager.LoadSceneAsync("Menu");
    }

    public void RestartPlayScene1()
    {
        PlayerPrefs.DeleteKey("PlayerScore");
        PlayerPrefs.DeleteKey("GameTime");

        SceneManager.LoadSceneAsync("Oyun");
    }

    public void RestartPlayScene2()
    {
        PlayerPrefs.DeleteKey("PlayerScore");
        PlayerPrefs.DeleteKey("GameTime");

        SceneManager.LoadSceneAsync("Oyun2");
    }

    public void Scene1Contunie()
    {
        SceneManager.LoadSceneAsync("Oyun");
    }

    public void Scene2Contunie()
    {
        SceneManager.LoadSceneAsync("Oyun2");
    }

    public void SureBittiScene1()
    {
        SceneManager.LoadSceneAsync("Oyun2");
    }

    public void MenuPanelAc()
    {
        panel.SetActive(true);
    }
}
