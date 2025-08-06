using UnityEngine;
using System.Linq; // Filtreleme için

public class VeriYukleyici : MonoBehaviour
{
    public TextAsset jsonDosyasi;
    public TabuKartListesi kartListesi;

    void Start()
    {
        // JSON'dan tüm kartlarý oku
        kartListesi = JsonUtility.FromJson<TabuKartListesi>(jsonDosyasi.text);

        // LevelSecim singleton'ýndan seçilen level'i al
        int secilenLevel = LevelSecim.Instance.secilenLevel;
        Debug.Log("Seçilen Level: " + secilenLevel);

        // Filtrele: sadece seçilen levele ait kartlarý al
        var secilenKartlar = kartListesi.kartlar
            .Where(kart => kart.level == secilenLevel)
            .ToList();

        // Konsola yaz
        foreach (var kart in secilenKartlar)
        {
            Debug.Log("Ana Kelime: " + kart.anaKelime);
            Debug.Log("Yasaklýlar: " + string.Join(", ", kart.yasakliKelimeler));
        }

        // Ek olarak bu kartlarý baþka bir yerde kullanacaksan:
        // bunlarý bir listede tutabilir ya da baþka bir metoda geçirebilirsin.
    }
}
