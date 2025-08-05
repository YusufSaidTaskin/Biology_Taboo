using UnityEngine;



[System.Serializable]
public class TabuKart
{
    public int level;
    public string anaKelime;
    public string[] yasakliKelimeler;
}

[System.Serializable]
public class TabuKartListesi
{
    public TabuKart[] kartlar;
}

