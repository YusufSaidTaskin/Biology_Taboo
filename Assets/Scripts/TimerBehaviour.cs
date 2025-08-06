using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using Unity.VisualScripting;

public class CountdownTimer : MonoBehaviour
{
    public TimeHolder timeHolder;
    private int countdownTime;        // Baþlangýç süresi
    public TextMeshProUGUI countdownText;            // UI üzerindeki Text (Legacy UI için)
    public GameObject panel;
    void Start()
    {
        countdownTime = timeHolder.totalTime;
        StartCoroutine(StartCountdownScene1());
    }

    IEnumerator StartCountdownScene1()
    {
        
        int currentTime = countdownTime;
        {
            
            while (currentTime > 0)
            {
                if (!panel.activeSelf)
                {
                    countdownText.text = currentTime.ToString();
                    yield return new WaitForSeconds(1f);
                    currentTime--;
                }
               
            }

            countdownText.text = "Süre Doldu!";
            FindAnyObjectByType<SceneControl>().SureBittiScene1();
        }
        
    }
}
