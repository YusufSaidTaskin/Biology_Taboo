using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TimeHolder timeHolder;
    private int countdownTime;        // Baþlangýç süresi
    public TextMeshProUGUI countdownText;            // UI üzerindeki Text (Legacy UI için)

    void Start()
    {
        countdownTime = timeHolder.totalTime;
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        int currentTime = countdownTime;

        while (currentTime > 0)
        {
            countdownText.text = currentTime.ToString();
            yield return new WaitForSeconds(1f);
            currentTime--;
        }

        countdownText.text = "Süre Doldu!";
        Debug.Log("Geri sayým bitti!");
    }
}
