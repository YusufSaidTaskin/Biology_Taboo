using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TimeHolder timeHolder;
    private int countdownTime;        // Ba�lang�� s�resi
    public TextMeshProUGUI countdownText;            // UI �zerindeki Text (Legacy UI i�in)

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

        countdownText.text = "S�re Doldu!";
        Debug.Log("Geri say�m bitti!");
    }
}
