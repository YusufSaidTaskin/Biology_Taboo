using UnityEngine;
using UnityEngine.UI;

public class PuanKontrol : MonoBehaviour
{
    Text puanText;
    int puan = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        puanText = GetComponent<Text>();
        puanText.text = "" + puan.ToString();
    }

    public void DogruButon() 
    {
        puan++;
        puanText.text = ""+puan.ToString();
    }

    public void TabuButon() 
    {
        puan--;
        puanText.text = ""+puan.ToString();
    }

    public void PasButon()
    {
        puan++;
        puan--;
        puanText.text = "" + puan.ToString();
    }

}
