//using System.Linq; // Filtreleme i�in
//using UnityEngine;

//public class VeriYukleyici : MonoBehaviour
//{
//    public TextAsset jsonDosyasi;
//    public TabuKartListesi kartListesi;

//    void Start()
//    {
//        // JSON'dan t�m kartlar� oku
//        kartListesi = JsonUtility.FromJson<TabuKartListesi>(jsonDosyasi.text);

//        // LevelSecim singleton'�ndan se�ilen level'i al
//        int secilenLevel = LevelSecim.Instance.secilenLevel;
//        Debug.Log("Se�ilen Level: " + secilenLevel);

//        // Filtrele: sadece se�ilen levele ait kartlar� al
//        var secilenKartlar = kartListesi.kartlar
//            .Where(kart => kart.level == secilenLevel)
//            .ToList();

//        // Konsola yaz
//        foreach (var kart in secilenKartlar)
//        {
//            Debug.Log("Ana Kelime: " + kart.anaKelime);
//            Debug.Log("Yasakl�lar: " + string.Join(", ", kart.yasakliKelimeler));
//        }

//        // Ek olarak bu kartlar� ba�ka bir yerde kullanacaksan:
//        // bunlar� bir listede tutabilir ya da ba�ka bir metoda ge�irebilirsin.
//    }
//}


using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.IO;

[System.Serializable]
public class TabuKart
{
    public string anaKelime;
    public List<string> yasakliKelimeler;
    public int level;
}

[System.Serializable]
public class TabuKartListesi
{
    public List<TabuKart> kartlar;
}

public class VeriYukleyici : MonoBehaviour
{
    public string dosyaAdi = "JSON_Dosya/biyoloji_tabu_50_kelime"; // Resources klas�r� alt�ndaki yol

    void Start()
    {
        // JSON dosyas�n� Resources klas�r�nden oku
        TextAsset jsonDosyasi = Resources.Load<TextAsset>(dosyaAdi);

        if (jsonDosyasi == null)
        {
            Debug.LogError("JSON dosyas� bulunamad�!");
            return;
        }

        // JSON verisini ��z�mle
        TabuKartListesi kartListesi = JsonUtility.FromJson<TabuKartListesi>(jsonDosyasi.text);

        if (kartListesi == null)
        {
            Debug.LogError("Kart listesi ��z�mlenemedi!");
            return;
        }

        // Se�ilen level'� al
        int secilenLevel = LevelSecim.Instance.secilenLevel;

        // O level'e ait kartlar� filtrele
        var secilenKartlar = kartListesi.kartlar
            .Where(kart => kart.level == secilenLevel)
            .ToList();

        // T�m kartlar� konsola yazd�r
        foreach (var kart in secilenKartlar)
        {
            Debug.Log("Ana Kelime: " + kart.anaKelime);
            Debug.Log("Yasakl� Kelimeler: " + string.Join(", ", kart.yasakliKelimeler));
            Debug.Log("-----");
        }
    }
}