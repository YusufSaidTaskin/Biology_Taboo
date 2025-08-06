using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using Unity.VisualScripting;

public class CountdownTimer : MonoBehaviour
{
    public TimeHolder timeHolder;
    private int countdownTime;        // Ba�lang�� s�resi
    public TextMeshProUGUI countdownText;            // UI �zerindeki Text (Legacy UI i�in)
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

            countdownText.text = "S�re Doldu!";
            FindAnyObjectByType<SceneControl>().SureBittiScene1();
        }
        
    }
}
