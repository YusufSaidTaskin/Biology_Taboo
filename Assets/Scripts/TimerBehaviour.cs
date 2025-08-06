using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using Unity.VisualScripting;
public class CountdownTimer : MonoBehaviour
{
    public TimeHolder timeHolder;
    private int countdownTime;
    public TextMeshProUGUI countdownText;
    public GameObject panel;

    void Start()
    {
        LoadTime();
        StartCoroutine(StartCountdownScene1());
    }

    IEnumerator StartCountdownScene1()
    {
        int currentTime = countdownTime;

        while (currentTime > 0)
        {
            while (panel.activeSelf)
            {
                yield return null;
            }

            countdownText.text = currentTime.ToString();

            SaveTime(currentTime);  // Süreyi her saniye kaydet

            currentTime--;

            yield return new WaitForSeconds(1f);
        }

        countdownText.text = "Süre Doldu!";
        PlayerPrefs.DeleteKey("GameTime"); // Süre bittiðinde kaydý temizle

        FindAnyObjectByType<SceneControl>().SureBittiScene1();
    }

    void SaveTime(int time)
    {
        PlayerPrefs.SetInt("GameTime", time);
        PlayerPrefs.Save();
    }

    void LoadTime()
    {
        if (PlayerPrefs.HasKey("GameTime"))
        {
            countdownTime = PlayerPrefs.GetInt("GameTime");
        }
        else
        {
            countdownTime = timeHolder.totalTime; // default süre
        }
    }
}