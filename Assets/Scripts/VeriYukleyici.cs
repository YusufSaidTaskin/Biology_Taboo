//using System.Linq; // Filtreleme için
//using UnityEngine;

//public class VeriYukleyici : MonoBehaviour
//{
//    public TextAsset jsonDosyasi;
//    public TabuKartListesi kartListesi;

//    void Start()
//    {
//        // JSON'dan tüm kartlarý oku
//        kartListesi = JsonUtility.FromJson<TabuKartListesi>(jsonDosyasi.text);

//        // LevelSecim singleton'ýndan seçilen level'i al
//        int secilenLevel = LevelSecim.Instance.secilenLevel;
//        Debug.Log("Seçilen Level: " + secilenLevel);

//        // Filtrele: sadece seçilen levele ait kartlarý al
//        var secilenKartlar = kartListesi.kartlar
//            .Where(kart => kart.level == secilenLevel)
//            .ToList();

//        // Konsola yaz
//        foreach (var kart in secilenKartlar)
//        {
//            Debug.Log("Ana Kelime: " + kart.anaKelime);
//            Debug.Log("Yasaklýlar: " + string.Join(", ", kart.yasakliKelimeler));
//        }

//        // Ek olarak bu kartlarý baþka bir yerde kullanacaksan:
//        // bunlarý bir listede tutabilir ya da baþka bir metoda geçirebilirsin.
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
    public string dosyaAdi = "JSON_Dosya/biyoloji_tabu_50_kelime"; // Resources klasörü altýndaki yol

    void Start()
    {
        // JSON dosyasýný Resources klasöründen oku
        TextAsset jsonDosyasi = Resources.Load<TextAsset>(dosyaAdi);

        if (jsonDosyasi == null)
        {
            Debug.LogError("JSON dosyasý bulunamadý!");
            return;
        }

        // JSON verisini çözümle
        TabuKartListesi kartListesi = JsonUtility.FromJson<TabuKartListesi>(jsonDosyasi.text);

        if (kartListesi == null)
        {
            Debug.LogError("Kart listesi çözümlenemedi!");
            return;
        }

        // Seçilen level'ý al
        int secilenLevel = LevelSecim.Instance.secilenLevel;

        // O level'e ait kartlarý filtrele
        var secilenKartlar = kartListesi.kartlar
            .Where(kart => kart.level == secilenLevel)
            .ToList();

        // Tüm kartlarý konsola yazdýr
        foreach (var kart in secilenKartlar)
        {
            Debug.Log("Ana Kelime: " + kart.anaKelime);
            Debug.Log("Yasaklý Kelimeler: " + string.Join(", ", kart.yasakliKelimeler));
            Debug.Log("-----");
        }
    }
}