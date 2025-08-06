using UnityEngine;
using UnityEngine.UI;

public class PuanKontrol : MonoBehaviour
{
    Text puanText;
    int puan = 0;

    void Start()
    {
        puanText = GetComponent<Text>();
        LoadScore();  // Ba�lang��ta puan� y�kle
        UpdateScoreText();
    }

    public void DogruButon()
    {
        puan++;
        UpdateScoreText();
        SaveScore();
    }

    public void TabuButon()
    {
        puan--;
        UpdateScoreText();
        SaveScore();
    }

    public void PasButon()
    {
        // puan de�i�miyor asl�nda, ama sen yine de text g�ncellemi�sin
        UpdateScoreText();
        SaveScore();
    }

    void UpdateScoreText()
    {
        puanText.text = puan.ToString();
    }

    void SaveScore()
    {
        PlayerPrefs.SetInt("PlayerScore", puan);
        PlayerPrefs.Save();
    }

    void LoadScore()
    {
        if (PlayerPrefs.HasKey("PlayerScore"))
        {
            puan = PlayerPrefs.GetInt("PlayerScore");
        }
        else
        {
            puan = 0;
        }
    }
}
